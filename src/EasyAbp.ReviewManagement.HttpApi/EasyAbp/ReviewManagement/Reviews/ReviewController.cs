using System;
using System.Threading.Tasks;
using EasyAbp.ReviewManagement.Reviews.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.ReviewManagement.Reviews
{
    [RemoteService(Name = "EasyAbpReviewManagement")]
    [Route("/api/reviewManagement/review")]
    public class ReviewController : ReviewManagementController, IReviewAppService
    {
        private readonly IReviewAppService _service;

        public ReviewController(IReviewAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public virtual Task<ReviewDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public virtual Task<PagedResultDto<ReviewDto>> GetListAsync(GetReviewListInput input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public virtual Task<ReviewDto> CreateAsync(CreateReviewDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public virtual Task<ReviewDto> UpdateAsync(Guid id, UpdateReviewDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public virtual Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }
    }
}