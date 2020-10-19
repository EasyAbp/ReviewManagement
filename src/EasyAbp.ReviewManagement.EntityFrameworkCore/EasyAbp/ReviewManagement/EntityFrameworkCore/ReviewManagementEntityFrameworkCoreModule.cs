using EasyAbp.ReviewManagement.Reviews;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EasyAbp.ReviewManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(ReviewManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class ReviewManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ReviewManagementDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<Review, ReviewRepository>();
            });
        }
    }
}
