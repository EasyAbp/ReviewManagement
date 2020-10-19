using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace EasyAbp.ReviewManagement.MongoDB
{
    [ConnectionStringName(ReviewManagementDbProperties.ConnectionStringName)]
    public class ReviewManagementMongoDbContext : AbpMongoDbContext, IReviewManagementMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureReviewManagement();
        }
    }
}