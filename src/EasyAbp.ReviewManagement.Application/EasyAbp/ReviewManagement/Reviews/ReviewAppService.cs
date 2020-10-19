using System;
using EasyAbp.ReviewManagement.Permissions;
using EasyAbp.ReviewManagement.Reviews.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.ReviewManagement.Reviews
{
    public class ReviewAppService : CrudAppService<Review, ReviewDto, Guid, PagedAndSortedResultRequestDto, CreateReviewDto, UpdateReviewDto>,
        IReviewAppService
    {
        protected override string GetPolicyName { get; set; } = ReviewManagementPermissions.Review.Default;
        protected override string GetListPolicyName { get; set; } = ReviewManagementPermissions.Review.Default;
        protected override string CreatePolicyName { get; set; } = ReviewManagementPermissions.Review.Create;
        protected override string UpdatePolicyName { get; set; } = ReviewManagementPermissions.Review.Update;
        protected override string DeletePolicyName { get; set; } = ReviewManagementPermissions.Review.Delete;

        private readonly IReviewRepository _repository;
        
        public ReviewAppService(IReviewRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
