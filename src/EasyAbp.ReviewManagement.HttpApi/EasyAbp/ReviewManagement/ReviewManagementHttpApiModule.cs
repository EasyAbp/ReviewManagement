using Localization.Resources.AbpUi;
using EasyAbp.ReviewManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace EasyAbp.ReviewManagement
{
    [DependsOn(
        typeof(ReviewManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ReviewManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ReviewManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ReviewManagementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
