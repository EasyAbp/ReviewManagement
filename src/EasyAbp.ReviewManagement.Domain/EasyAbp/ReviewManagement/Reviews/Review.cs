using System;
using JetBrains.Annotations;
using Volo.Abp;
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
        
        public virtual short StarCount { get; protected set; }
        
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
            short starCount, 
            bool isPublic,
            ReviewDetail reviewDetail
        ) : base(id)
        {
            TenantId = tenantId;
            EntityType = Check.NotNullOrWhiteSpace(entityType, nameof(entityType), ReviewConsts.MaxEntityTypeLength);
            EntityId = Check.NotNullOrWhiteSpace(entityId, nameof(entityId), ReviewConsts.MaxEntityIdLength);
            SetStarCount(starCount);
            IsPublic = isPublic;
            ReviewDetail = reviewDetail;
        }

        public virtual void Update(
            short starCount,
            bool isPublic,
            ReviewDetail reviewDetail)
        {
            SetStarCount(starCount);
            IsPublic = isPublic;
            ReviewDetail = reviewDetail;
        }
        
        public virtual void SetStarCount(short starCount)
        {
            if(starCount <= ReviewConsts.MaxStarCount && starCount >= ReviewConsts.MinStarCount)
            {
                StarCount = starCount;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Choosen star must between {ReviewConsts.MinStarCount} and {ReviewConsts.MaxStarCount}");
            }
        }
    }
}
