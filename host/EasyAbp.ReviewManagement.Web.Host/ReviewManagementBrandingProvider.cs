using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.ReviewManagement
{
    [Dependency(ReplaceServices = true)]
    public class ReviewManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ReviewManagement";
    }
}
