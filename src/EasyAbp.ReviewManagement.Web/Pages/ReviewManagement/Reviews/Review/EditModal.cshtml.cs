using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyAbp.ReviewManagement.Reviews;
using EasyAbp.ReviewManagement.Reviews.Dtos;
using EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels;

namespace EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review
{
    public class EditModalModel : ReviewManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public EditReviewViewModel ViewModel { get; set; }

        private readonly IReviewAppService _service;

        public EditModalModel(IReviewAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<ReviewDto, EditReviewViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditReviewViewModel, UpdateReviewDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}