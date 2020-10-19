namespace EasyAbp.ReviewManagement
{
    public static class ReviewManagementDbProperties
    {
        public static string DbTablePrefix { get; set; } = "EasyAbpReviewManagement";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "EasyAbpReviewManagement";
    }
}
