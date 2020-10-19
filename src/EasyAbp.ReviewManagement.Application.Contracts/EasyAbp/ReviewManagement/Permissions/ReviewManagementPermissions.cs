using Volo.Abp.Reflection;

namespace EasyAbp.ReviewManagement.Permissions
{
    public class ReviewManagementPermissions
    {
        public const string GroupName = "EasyAbp.ReviewManagement";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ReviewManagementPermissions));
        }

        public class Review
        {
            public const string Default = GroupName + ".Review";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
