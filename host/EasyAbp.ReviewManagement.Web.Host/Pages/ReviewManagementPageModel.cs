using EasyAbp.ReviewManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.ReviewManagement.Pages
{
    public abstract class ReviewManagementPageModel : AbpPageModel
    {
        protected ReviewManagementPageModel()
        {
            LocalizationResourceType = typeof(ReviewManagementResource);
        }
    }
}