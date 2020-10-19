using System;
using System.ComponentModel;
namespace EasyAbp.ReviewManagement.Reviews.Dtos
{
    [Serializable]
    public class CreateUpdateReviewDetailDto
    {
        [DisplayName("ReviewDetailText")]
        public string Text { get; set; }

        [DisplayName("ReviewDetailMediaResources")]
        public string MediaResources { get; set; }
    }
}