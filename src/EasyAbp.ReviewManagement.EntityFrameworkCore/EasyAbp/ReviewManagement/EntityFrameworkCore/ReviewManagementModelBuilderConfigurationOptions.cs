using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EasyAbp.ReviewManagement.EntityFrameworkCore
{
    public class ReviewManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ReviewManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}