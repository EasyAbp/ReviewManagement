using System.Security.Principal;
using System.Threading.Tasks;
using EasyAbp.ReviewManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.ReviewManagement.Reviews.Authorization
{
    public class
        BasicCreateReviewAuthorizationHandler : AuthorizationHandler<CreateReviewAuthorizationRequirement>,
            ITransientDependency
    {
        private readonly IPermissionChecker _permissionChecker;

        public BasicCreateReviewAuthorizationHandler(IPermissionChecker permissionChecker)
        {
            _permissionChecker = permissionChecker;
        }
        
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context,
            CreateReviewAuthorizationRequirement requirement)
        {
            if (!await _permissionChecker.IsGrantedAsync(ReviewManagementPermissions.Review.Create))
            {
                context.Fail();
            }
            
            // Should execute context.Succeed(requirement) in other handlers.
        }
    }
}