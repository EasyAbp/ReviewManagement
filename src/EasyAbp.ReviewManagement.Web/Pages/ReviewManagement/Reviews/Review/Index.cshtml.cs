using System.Threading.Tasks;

namespace EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review
{
    public class IndexModel : ReviewManagementPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
