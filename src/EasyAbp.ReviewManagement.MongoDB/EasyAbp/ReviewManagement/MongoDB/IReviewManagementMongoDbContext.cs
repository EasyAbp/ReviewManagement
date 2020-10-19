using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace EasyAbp.ReviewManagement.MongoDB
{
    [ConnectionStringName(ReviewManagementDbProperties.ConnectionStringName)]
    public interface IReviewManagementMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
