using System;

using System.ComponentModel.DataAnnotations;

namespace EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels
{
    public class CreateReviewViewModel
    {
        [Display(Name = "ReviewEntityType")]
        public string EntityType { get; set; }

        [Display(Name = "ReviewEntityId")]
        public string EntityId { get; set; }

        [Display(Name = "ReviewStarCount")]
        public StarCount StarCount { get; set; }

        [Display(Name = "ReviewReviewDetail")]
        public CreateReviewDetailViewModel ReviewDetail { get; set; }
        
        [Display(Name = "ReviewIsPublic")]
        public bool IsPublic { get; set; }
    }
}