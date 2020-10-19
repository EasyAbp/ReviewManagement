using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyAbp.ReviewManagement.Reviews;
using EasyAbp.ReviewManagement.Reviews.Dtos;
using EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels;

namespace EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review
{
    public class CreateModalModel : ReviewManagementPageModel
    {
        [BindProperty]
        public CreateReviewViewModel ViewModel { get; set; }

        private readonly IReviewAppService _service;

        public CreateModalModel(IReviewAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateReviewViewModel, CreateReviewDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}