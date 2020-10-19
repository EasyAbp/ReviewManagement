using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace EasyAbp.ReviewManagement.MongoDB
{
    public static class ReviewManagementMongoDbContextExtensions
    {
        public static void ConfigureReviewManagement(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ReviewManagementMongoModelBuilderConfigurationOptions(
                ReviewManagementDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}