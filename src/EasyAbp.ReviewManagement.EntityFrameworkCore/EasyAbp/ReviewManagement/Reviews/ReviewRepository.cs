using System;
using System.Linq;
using EasyAbp.ReviewManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.ReviewManagement.Reviews
{
    public class ReviewRepository : EfCoreRepository<IReviewManagementDbContext, Review, Guid>, IReviewRepository
    {
        public ReviewRepository(IDbContextProvider<IReviewManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override IQueryable<Review> WithDetails()
        {
            return DbSet.IncludeDetails();
        }
    }
}