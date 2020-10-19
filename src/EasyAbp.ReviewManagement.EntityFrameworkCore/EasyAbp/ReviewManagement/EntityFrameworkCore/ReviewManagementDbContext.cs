using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using EasyAbp.ReviewManagement.Reviews;

namespace EasyAbp.ReviewManagement.EntityFrameworkCore
{
    [ConnectionStringName(ReviewManagementDbProperties.ConnectionStringName)]
    public class ReviewManagementDbContext : AbpDbContext<ReviewManagementDbContext>, IReviewManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewDetail> ReviewDetails { get; set; }

        public ReviewManagementDbContext(DbContextOptions<ReviewManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureReviewManagement();
        }
    }
}
