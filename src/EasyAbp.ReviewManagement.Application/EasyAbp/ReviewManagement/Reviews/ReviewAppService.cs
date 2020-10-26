using System;
using System.Linq;
using System.Threading.Tasks;
using EasyAbp.ReviewManagement.Reviews.Authorization;
using EasyAbp.ReviewManagement.Reviews.Dtos;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Users;

namespace EasyAbp.ReviewManagement.Reviews
{
    public class ReviewAppService : CrudAppService<Review, ReviewDto, Guid, GetReviewListInput, CreateReviewDto, UpdateReviewDto>,
        IReviewAppService
    {
        private readonly IExternalUserLookupServiceProvider _externalUserLookupServiceProvider;
        private readonly IReviewRepository _repository;
        
        public ReviewAppService(
            IExternalUserLookupServiceProvider externalUserLookupServiceProvider,
            IReviewRepository repository) : base(repository)
        {
            _externalUserLookupServiceProvider = externalUserLookupServiceProvider;
            _repository = repository;
        }

        public override async Task<ReviewDto> GetAsync(Guid id)
        {
            var review = await GetEntityByIdAsync(id);

            await AuthorizationService.CheckAsync(review,
                new GetReviewAuthorizationRequirement());
            
            return await MapToGetOutputDtoAsync(review);
        }

        protected override IQueryable<Review> CreateFilteredQuery(GetReviewListInput input)
        {
            return _repository.WithDetails()
                .WhereIf(input.EntityType != null, x => x.EntityType == input.EntityType)
                .WhereIf(input.EntityType != null && input.EntityId != null, x => x.EntityId == input.EntityId)
                .WhereIf(input.CreatorId.HasValue, x => x.CreatorId == input.CreatorId);
        }

        public override async Task<PagedResultDto<ReviewDto>> GetListAsync(GetReviewListInput input)
        {
            await AuthorizationService.CheckAsync(null, new GetReviewListAuthorizationRequirement {Input = input});

            var query = CreateFilteredQuery(input);

            var totalCount = await AsyncExecuter.CountAsync(query);

            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);

            var entities = await AsyncExecuter.ToListAsync(query);
            var entityDtos = await MapToGetListOutputDtosAsync(entities);

            return new PagedResultDto<ReviewDto>(
                totalCount,
                entityDtos
            );
        }

        protected override Review MapToEntity(CreateReviewDto createInput)
        {
            var reviewDetail = new ReviewDetail(GuidGenerator.Create(), createInput.ReviewDetail.Text,
                createInput.ReviewDetail.MediaResources);

            return new Review(GuidGenerator.Create(), CurrentTenant.Id, createInput.EntityType,
                createInput.EntityId, createInput.StarCount, createInput.IsPublic, reviewDetail);
        }

        protected override void MapToEntity(UpdateReviewDto updateInput, Review entity)
        {
            var reviewDetail = entity.ReviewDetail;

            reviewDetail.Update(updateInput.ReviewDetail.Text, updateInput.ReviewDetail.MediaResources);
            
            entity.Update(updateInput.StarCount, updateInput.IsPublic, reviewDetail);
        }

        protected override async Task<ReviewDto> MapToGetListOutputDtoAsync(Review entity)
        {
            var dto = await base.MapToGetListOutputDtoAsync(entity);

            if (!entity.CreatorId.HasValue)
            {
                return dto;
            }

            var userData = await _externalUserLookupServiceProvider.FindByIdAsync(entity.CreatorId.Value);
            
            dto.CreatorUserName = userData?.UserName;

            return dto;
        }

        protected override async Task<ReviewDto> MapToGetOutputDtoAsync(Review entity)
        {
            var dto = await base.MapToGetOutputDtoAsync(entity);

            if (!entity.CreatorId.HasValue)
            {
                return dto;
            }

            var userData = await _externalUserLookupServiceProvider.FindByIdAsync(entity.CreatorId.Value);
            
            dto.CreatorUserName = userData?.UserName;

            return dto;
        }

        public override async Task<ReviewDto> CreateAsync(CreateReviewDto input)
        {
            await AuthorizationService.CheckAsync(null, new CreateReviewAuthorizationRequirement {Input = input});

            var review = await MapToEntityAsync(input);

            TryToSetTenantId(review);

            await Repository.InsertAsync(review, autoSave: true);

            return await MapToGetOutputDtoAsync(review);
        }

        public override async Task<ReviewDto> UpdateAsync(Guid id, UpdateReviewDto input)
        {
            var review = await GetEntityByIdAsync(id);
            
            await AuthorizationService.CheckAsync(review, new UpdateReviewAuthorizationRequirement {Input = input});
            
            await MapToEntityAsync(input, review);
            
            await Repository.UpdateAsync(review, autoSave: true);

            return await MapToGetOutputDtoAsync(review);
        }

        public override async Task DeleteAsync(Guid id)
        {
            var review = await GetEntityByIdAsync(id);

            await AuthorizationService.CheckAsync(review, new DeleteReviewAuthorizationRequirement());

            await _repository.DeleteAsync(review, true);
        }
    }
}
