using System;

using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels
{
    public class ReadReviewViewModel
    {
        [DisabledInput]
        [Display(Name = "ReviewEntityType")]
        public string EntityType { get; set; }

        [DisabledInput]
        [Display(Name = "ReviewEntityId")]
        public string EntityId { get; set; }

        [DisabledInput]
        [Display(Name = "ReviewStarCount")]
        public StarCount StarCount { get; set; }

        [DisabledInput]
        [Display(Name = "ReviewReviewDetail")]
        public ReadReviewDetailViewModel ReviewDetail { get; set; }
        
        [DisabledInput]
        [Display(Name = "ReviewIsPublic")]
        public bool IsPublic { get; set; }
    }
}