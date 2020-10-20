using System;

using System.ComponentModel.DataAnnotations;

namespace EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels
{
    public class EditReviewViewModel
    {
        [Display(Name = "ReviewStarCount")]
        public StarCount StarCount { get; set; }

        [Display(Name = "ReviewReviewDetail")]
        public EditReviewDetailViewModel ReviewDetail { get; set; }

        [Display(Name = "ReviewIsPublic")]
        public bool IsPublic { get; set; }
    }
}