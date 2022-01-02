using EasyAbp.ReviewManagement.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.ReviewManagement
{
    [Area(ReviewManagementRemoteServiceConsts.ModuleName)]
    public abstract class ReviewManagementController : AbpControllerBase
    {
        protected ReviewManagementController()
        {
            LocalizationResource = typeof(ReviewManagementResource);
        }
    }
}
