using EasyAbp.ReviewManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.ReviewManagement.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ReviewManagementPageModel : AbpPageModel
    {
        protected ReviewManagementPageModel()
        {
            LocalizationResourceType = typeof(ReviewManagementResource);
            ObjectMapperContext = typeof(ReviewManagementWebModule);
        }
    }
}