using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace EasyAbp.ReviewManagement.MongoDB
{
    public class ReviewManagementMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public ReviewManagementMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}