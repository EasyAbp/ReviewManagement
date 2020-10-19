using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace EasyAbp.ReviewManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ReviewManagementDomainSharedModule)
    )]
    public class ReviewManagementDomainModule : AbpModule
    {

    }
}
