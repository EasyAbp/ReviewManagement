using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.ReviewManagement.Reviews.Authorization
{
    public class
        BasicGetReviewListAuthorizationHandler : AuthorizationHandler<GetReviewListAuthorizationRequirement>,
            ITransientDependency
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            GetReviewListAuthorizationRequirement requirement)
        {
            var input = requirement.Input;
            
            if (input.CreatorId.HasValue && input.CreatorId.Value == context.User.FindUserId())
            {
                context.Fail();
                return Task.CompletedTask;
            }

            context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}