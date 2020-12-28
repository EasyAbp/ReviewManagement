using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EasyAbp.ReviewManagement
{
    [Dependency(ReplaceServices = true)]
    public class ReviewManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ReviewManagement";
    }
}
