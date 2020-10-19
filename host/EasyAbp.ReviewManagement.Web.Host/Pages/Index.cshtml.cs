using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace EasyAbp.ReviewManagement.Pages
{
    public class IndexModel : ReviewManagementPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}