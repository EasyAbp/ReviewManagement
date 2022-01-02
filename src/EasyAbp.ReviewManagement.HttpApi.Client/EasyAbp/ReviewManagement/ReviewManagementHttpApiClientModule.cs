using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.ReviewManagement
{
    [DependsOn(
        typeof(ReviewManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ReviewManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = ReviewManagementRemoteServiceConsts.RemoteServiceName;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ReviewManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
            
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<ReviewManagementApplicationContractsModule>();
            });
        }
    }
}
