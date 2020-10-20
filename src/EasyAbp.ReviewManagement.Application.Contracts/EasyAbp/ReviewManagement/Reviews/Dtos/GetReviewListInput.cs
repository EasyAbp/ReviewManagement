using System;
using JetBrains.Annotations;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.ReviewManagement.Reviews.Dtos
{
    public class GetReviewListInput : PagedAndSortedResultRequestDto
    {
        [CanBeNull]
        public string EntityType { get; set; }
        
        [CanBeNull]
        public string EntityId { get; set; }
        
        public Guid? CreatorId { get; set; }
    }
}