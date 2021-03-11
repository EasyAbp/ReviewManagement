using System;
using System.Linq;
using System.Threading.Tasks;
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

        public override async Task<IQueryable<Review>> WithDetailsAsync()
        {
            return (await GetDbSetAsync()).IncludeDetails();
        }
    }
}