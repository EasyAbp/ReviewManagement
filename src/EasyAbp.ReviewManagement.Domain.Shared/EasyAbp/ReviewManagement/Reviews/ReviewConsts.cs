namespace EasyAbp.ReviewManagement.Reviews
{
    public class ReviewConsts
    {
        public static int MaxEntityTypeLength { get; set; } = 64;

        public static int MaxEntityIdLength { get; set; } = 64;

        public static int MaxStarCount { get; set; } = 5;

        public static int MinStarCount { get; set; } = 1;
        
        public static int MaxTextLength { get; set; } = 1024;
        
        public static int MaxMediaResourcesLength { get; set; } = 1024;
    }
}