using EasyAbp.ReviewManagement.Localization;
using Volo.Abp.Application.Services;

namespace EasyAbp.ReviewManagement
{
    public abstract class ReviewManagementAppService : ApplicationService
    {
        protected ReviewManagementAppService()
        {
            LocalizationResource = typeof(ReviewManagementResource);
            ObjectMapperContext = typeof(ReviewManagementApplicationModule);
        }
    }
}
