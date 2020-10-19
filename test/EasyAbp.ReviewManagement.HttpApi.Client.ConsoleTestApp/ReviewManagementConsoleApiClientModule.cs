using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace EasyAbp.ReviewManagement
{
    [DependsOn(
        typeof(ReviewManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ReviewManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
