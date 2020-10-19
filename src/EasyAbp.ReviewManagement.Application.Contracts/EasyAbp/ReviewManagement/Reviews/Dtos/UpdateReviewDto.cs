using System;
using System.ComponentModel;

namespace EasyAbp.ReviewManagement.Reviews.Dtos
{
    [Serializable]
    public class UpdateReviewDto
    {
        public string EntityType { get; set; }

        public string EntityId { get; set; }

        public short StartCount { get; set; }

        public bool IsPublic { get; set; }
        
        public CreateUpdateReviewDetailDto ReviewDetail { get; set; }
    }
}