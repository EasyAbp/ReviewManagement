using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace EasyAbp.ReviewManagement
{
    [DependsOn(
        typeof(ReviewManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class ReviewManagementApplicationContractsModule : AbpModule
    {

    }
}
