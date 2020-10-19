using EasyAbp.ReviewManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.ReviewManagement
{
    public abstract class ReviewManagementController : AbpController
    {
        protected ReviewManagementController()
        {
            LocalizationResource = typeof(ReviewManagementResource);
        }
    }
}
