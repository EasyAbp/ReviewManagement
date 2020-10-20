using EasyAbp.ReviewManagement.Reviews.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace EasyAbp.ReviewManagement.Reviews.Authorization
{
    public class CreateReviewAuthorizationRequirement : IAuthorizationRequirement
    {
        public CreateReviewDto Input { get; set; }
    }
}