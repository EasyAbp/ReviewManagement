using System.Security.Principal;
using System.Threading.Tasks;
using EasyAbp.ReviewManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.ReviewManagement.Reviews.Authorization
{
    public class
        BasicDeleteReviewAuthorizationHandler : AuthorizationHandler<DeleteReviewAuthorizationRequirement, Review>,
            ITransientDependency
    {
        private readonly IPermissionChecker _permissionChecker;

        public BasicDeleteReviewAuthorizationHandler(IPermissionChecker permissionChecker)
        {
            _permissionChecker = permissionChecker;
        }
        
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context,
            DeleteReviewAuthorizationRequirement requirement, Review resource)
        {
            if (!await _permissionChecker.IsGrantedAsync(ReviewManagementPermissions.Review.Delete))
            {
                context.Fail();
            }

            if (resource.CreatorId != context.User.FindUserId() &&
                !await _permissionChecker.IsGrantedAsync(ReviewManagementPermissions.Review.Manage))
            {
                context.Fail();
            }

            // Should execute context.Succeed(requirement) in other handlers.
        }
    }
}