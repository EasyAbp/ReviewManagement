using EasyAbp.ReviewManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EasyAbp.ReviewManagement.Permissions
{
    public class ReviewManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ReviewManagementPermissions.GroupName, L("Permission:ReviewManagement"));

            var reviewPermission = myGroup.AddPermission(ReviewManagementPermissions.Review.Default, L("Permission:Review"));
            reviewPermission.AddChild(ReviewManagementPermissions.Review.Create, L("Permission:Create"));
            reviewPermission.AddChild(ReviewManagementPermissions.Review.Update, L("Permission:Update"));
            reviewPermission.AddChild(ReviewManagementPermissions.Review.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ReviewManagementResource>(name);
        }
    }
}
