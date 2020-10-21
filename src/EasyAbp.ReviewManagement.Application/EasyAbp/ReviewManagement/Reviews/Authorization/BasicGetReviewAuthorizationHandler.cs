using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.ReviewManagement.Reviews.Authorization
{
    public class BasicGetReviewAuthorizationHandler : AuthorizationHandler<GetReviewAuthorizationRequirement, Review>,
        ITransientDependency
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            GetReviewAuthorizationRequirement requirement, Review resource)
        {
            if (resource == null)
            {
                context.Fail();
                return Task.CompletedTask;
            }
            
            context.Succeed(requirement);
            
            return Task.CompletedTask;
        }
    }
}