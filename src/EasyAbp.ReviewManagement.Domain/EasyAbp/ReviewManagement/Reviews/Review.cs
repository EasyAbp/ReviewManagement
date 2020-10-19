using System;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace EasyAbp.ReviewManagement.Reviews
{
    public class Review : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; protected set; }
        
        [NotNull]
        public virtual string EntityType { get; protected set; }
        
        [NotNull]
        public virtual string EntityId { get; protected set; }
        
        public virtual short StartCount { get; protected set; }
        
        public virtual bool IsPublic { get; protected set; }
        
        public virtual ReviewDetail ReviewDetail { get; protected set; }

        protected Review()
        {
        }

        public Review(
            Guid id, 
            Guid? tenantId, 
            string entityType, 
            string entityId, 
            short startCount, 
            bool isPublic,
            ReviewDetail reviewDetail
        ) : base(id)
        {
            TenantId = tenantId;
            EntityType = entityType;
            EntityId = entityId;
            StartCount = startCount;
            IsPublic = isPublic;
            ReviewDetail = reviewDetail;
        }
    }
}
