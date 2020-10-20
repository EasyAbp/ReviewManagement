using System;

using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels
{
    public class CreateReviewDetailViewModel
    {
        [TextArea(Rows = 4)]
        [Display(Name = "ReviewDetailText")]
        public string Text { get; set; }

        [Display(Name = "ReviewDetailMediaResources")]
        public string MediaResources { get; set; }
    }
}