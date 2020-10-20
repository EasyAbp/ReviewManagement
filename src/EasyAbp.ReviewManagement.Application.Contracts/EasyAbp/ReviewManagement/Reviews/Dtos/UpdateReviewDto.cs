using System;
using System.ComponentModel;
using Volo.Abp.ObjectExtending;

namespace EasyAbp.ReviewManagement.Reviews.Dtos
{
    [Serializable]
    public class UpdateReviewDto : ExtensibleObject
    {
        public short StarCount { get; set; }

        public bool IsPublic { get; set; }
        
        public CreateUpdateReviewDetailDto ReviewDetail { get; set; }
    }
}