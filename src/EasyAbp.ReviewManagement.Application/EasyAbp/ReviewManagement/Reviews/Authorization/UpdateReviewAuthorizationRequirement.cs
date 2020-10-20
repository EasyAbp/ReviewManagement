using EasyAbp.ReviewManagement.Reviews.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace EasyAbp.ReviewManagement.Reviews.Authorization
{
    public class UpdateReviewAuthorizationRequirement : IAuthorizationRequirement
    {
        public UpdateReviewDto Input { get; set; }
    }
}