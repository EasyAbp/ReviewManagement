using System;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.ReviewManagement.Reviews.Dtos
{
    [Serializable]
    public class ReviewDto : FullAuditedEntityDto<Guid>
    {
        public string EntityType { get; set; }

        public string EntityId { get; set; }

        public short StartCount { get; set; }

        public bool IsPublic { get; set; }
        
        public ReviewDetailDto ReviewDetail { get; set; }
    }
}