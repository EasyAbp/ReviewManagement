using System;
using System.Threading.Tasks;
using EasyAbp.ReviewManagement.Reviews;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace EasyAbp.ReviewManagement.EntityFrameworkCore.Reviews
{
    public class ReviewRepositoryTests : ReviewManagementEntityFrameworkCoreTestBase
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewRepositoryTests()
        {
            _reviewRepository = GetRequiredService<IReviewRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
