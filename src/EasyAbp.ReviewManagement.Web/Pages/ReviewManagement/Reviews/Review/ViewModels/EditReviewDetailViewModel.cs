using System;

using System.ComponentModel.DataAnnotations;

namespace EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels
{
    public class EditReviewDetailViewModel
    {
        [Display(Name = "ReviewDetailText")]
        public string Text { get; set; }

        [Display(Name = "ReviewDetailMediaResources")]
        public string MediaResources { get; set; }
    }
}