using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EasyAbp.ReviewManagement.EntityFrameworkCore
{
    public class ReviewManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ReviewManagementHttpApiHostMigrationsDbContext>
    {
        public ReviewManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ReviewManagementHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("ReviewManagement"));

            return new ReviewManagementHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
