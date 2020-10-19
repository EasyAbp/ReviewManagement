using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EasyAbp.ReviewManagement.Reviews
{
    public static class ReviewEfCoreQueryableExtensions
    {
        public static IQueryable<Review> IncludeDetails(this IQueryable<Review> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable.Include(x => x.ReviewDetail);
        }
    }
}