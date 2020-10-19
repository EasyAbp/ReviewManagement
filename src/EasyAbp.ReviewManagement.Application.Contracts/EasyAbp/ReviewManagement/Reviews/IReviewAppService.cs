using System;
using EasyAbp.ReviewManagement.Reviews.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.ReviewManagement.Reviews
{
    public interface IReviewAppService :
        ICrudAppService< 
            ReviewDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateReviewDto,
            UpdateReviewDto>
    {

    }
}