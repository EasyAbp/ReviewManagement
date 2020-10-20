using System.Collections.Generic;
using System.Threading.Tasks;
using EasyAbp.ReviewManagement.Localization;
using EasyAbp.ReviewManagement.Permissions;
using Volo.Abp.UI.Navigation;

namespace EasyAbp.ReviewManagement.Web.Menus
{
    public class ReviewManagementMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenu(context);
            }
        }

        private async Task ConfigureMainMenu(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<ReviewManagementResource>();
             //Add main menu items.
             
            var reviewManagementMenuItem = new ApplicationMenuItem(ReviewManagementMenus.Prefix, l["Menu:ReviewManagement"]);

            if (await context.IsGrantedAsync(ReviewManagementPermissions.Review.Manage))
            {
                reviewManagementMenuItem.AddItem(
                    new ApplicationMenuItem(ReviewManagementMenus.Review, l["Menu:Review"], "/ReviewManagement/Reviews/Review")
                );
            }
            
            if (!reviewManagementMenuItem.Items.IsNullOrEmpty())
            {
                context.Menu.Items.Add(reviewManagementMenuItem);
            }
        }
    }
}
