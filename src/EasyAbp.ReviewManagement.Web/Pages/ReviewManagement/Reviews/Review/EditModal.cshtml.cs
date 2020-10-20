using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyAbp.ReviewManagement.Reviews;
using EasyAbp.ReviewManagement.Reviews.Dtos;
using EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels;
using Volo.Abp.ObjectExtending;

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
            var dto = await _service.GetAsync(Id);

            var updateDto = ObjectMapper.Map<EditReviewViewModel, UpdateReviewDto>(ViewModel);
            
            dto.MapExtraPropertiesTo(updateDto, MappingPropertyDefinitionChecks.None);
            
            await _service.UpdateAsync(Id, updateDto);
            return NoContent();
        }
    }
}