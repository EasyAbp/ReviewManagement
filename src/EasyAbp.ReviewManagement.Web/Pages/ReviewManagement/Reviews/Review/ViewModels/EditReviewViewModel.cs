using System;

using System.ComponentModel.DataAnnotations;

namespace EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels
{
    public class EditReviewViewModel
    {
        [Display(Name = "ReviewEntityType")]
        public string EntityType { get; set; }

        [Display(Name = "ReviewEntityId")]
        public string EntityId { get; set; }

        [Display(Name = "ReviewStartCount")]
        public short StartCount { get; set; }

        [Display(Name = "ReviewIsPublic")]
        public bool IsPublic { get; set; }
        
        [Display(Name = "ReviewReviewDetail")]
        public EditReviewDetailViewModel ReviewDetail { get; set; }
    }
}