using System;
using Volo.Abp.Domain.Repositories;

namespace EasyAbp.ReviewManagement.Reviews
{
    public interface IReviewRepository : IRepository<Review, Guid>
    {
    }
}