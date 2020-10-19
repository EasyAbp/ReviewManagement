using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace EasyAbp.ReviewManagement.EntityFrameworkCore
{
    public class ReviewManagementHttpApiHostMigrationsDbContext : AbpDbContext<ReviewManagementHttpApiHostMigrationsDbContext>
    {
        public ReviewManagementHttpApiHostMigrationsDbContext(DbContextOptions<ReviewManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureReviewManagement();
            modelBuilder.ConfigureAuditLogging();
            modelBuilder.ConfigurePermissionManagement();
            modelBuilder.ConfigureSettingManagement();
        }
    }
}
