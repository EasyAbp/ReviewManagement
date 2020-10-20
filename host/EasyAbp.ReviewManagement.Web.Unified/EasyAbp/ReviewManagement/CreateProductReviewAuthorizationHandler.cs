using System.Threading.Tasks;
using EasyAbp.ReviewManagement.Reviews.Authorization;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.ReviewManagement
{
    public class CreateProductReviewAuthorizationHandler : AuthorizationHandler<CreateReviewAuthorizationRequirement>,
        ITransientDependency
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CreateReviewAuthorizationRequirement requirement)
        {
            const string productEntityType = "Product";

            if (requirement.Input.EntityType != productEntityType)
            {
                return Task.CompletedTask;
            }
            
            // Check if the product exists and the current user has purchased it.

            context.Succeed(requirement);
            
            return Task.CompletedTask;
        }
    }
}