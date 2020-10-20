using System;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities;

namespace EasyAbp.ReviewManagement.Reviews
{
    public class ReviewDetail : Entity<Guid>
    {
        [CanBeNull]
        public virtual string Text { get; protected set; }
        
        [CanBeNull]
        public virtual string MediaResources { get; protected set; }

        protected ReviewDetail()
        {
        }

        public ReviewDetail(
            Guid id, 
            [CanBeNull] string text, 
            [CanBeNull] string mediaResources
        ) : base(id)
        {
            Text = text;
            MediaResources = mediaResources;
        }

        public void Update(
            [CanBeNull] string text, 
            [CanBeNull] string mediaResources)
        {
            Text = text;
            MediaResources = mediaResources;
        }
    }
}
