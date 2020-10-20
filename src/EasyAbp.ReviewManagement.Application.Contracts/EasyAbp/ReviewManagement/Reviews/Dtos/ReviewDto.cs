using System;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.ReviewManagement.Reviews.Dtos
{
    [Serializable]
    public class ReviewDto : ExtensibleFullAuditedEntityDto<Guid>
    {
        public string EntityType { get; set; }

        public string EntityId { get; set; }

        public short StarCount { get; set; }

        public bool IsPublic { get; set; }
        
        public ReviewDetailDto ReviewDetail { get; set; }
        
        public string CreatorUserName { get; set; }
    }
}