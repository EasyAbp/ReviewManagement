using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using EasyAbp.ReviewManagement.Reviews;

namespace EasyAbp.ReviewManagement.EntityFrameworkCore
{
    [ConnectionStringName(ReviewManagementDbProperties.ConnectionStringName)]
    public interface IReviewManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Review> Reviews { get; set; }
        DbSet<ReviewDetail> ReviewDetails { get; set; }
    }
}
