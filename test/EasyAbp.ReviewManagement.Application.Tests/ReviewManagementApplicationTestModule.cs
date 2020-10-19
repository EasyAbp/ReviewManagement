using Volo.Abp.Modularity;

namespace EasyAbp.ReviewManagement
{
    [DependsOn(
        typeof(ReviewManagementApplicationModule),
        typeof(ReviewManagementDomainTestModule)
        )]
    public class ReviewManagementApplicationTestModule : AbpModule
    {

    }
}
