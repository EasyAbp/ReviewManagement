using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace EasyAbp.ReviewManagement.Reviews
{
    public class ReviewAppServiceTests : ReviewManagementApplicationTestBase
    {
        private readonly IReviewAppService _reviewAppService;

        public ReviewAppServiceTests()
        {
            _reviewAppService = GetRequiredService<IReviewAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
