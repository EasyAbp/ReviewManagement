using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.ObjectExtending;

namespace EasyAbp.ReviewManagement.Reviews.Dtos
{
    [Serializable]
    public class CreateReviewDto : ExtensibleObject
    {
        public string EntityType { get; set; }

        public string EntityId { get; set; }

        public short StarCount { get; set; }

        public bool IsPublic { get; set; }
        
        public CreateUpdateReviewDetailDto ReviewDetail { get; set; }
    }
}