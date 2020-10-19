using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace EasyAbp.ReviewManagement
{
    [DependsOn(
        typeof(ReviewManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ReviewManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "EasyAbpReviewManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ReviewManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
