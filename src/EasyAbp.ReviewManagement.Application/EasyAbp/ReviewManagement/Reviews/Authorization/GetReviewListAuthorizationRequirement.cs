using EasyAbp.ReviewManagement.Reviews.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace EasyAbp.ReviewManagement.Reviews.Authorization
{
    public class GetReviewListAuthorizationRequirement : IAuthorizationRequirement
    {
        public GetReviewListInput Input { get; set; }
    }
}