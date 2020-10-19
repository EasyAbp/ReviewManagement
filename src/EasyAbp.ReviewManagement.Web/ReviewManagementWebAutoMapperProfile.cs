using EasyAbp.ReviewManagement.Reviews.Dtos;
using EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels;
using AutoMapper;

namespace EasyAbp.ReviewManagement.Web
{
    public class ReviewManagementWebAutoMapperProfile : Profile
    {
        public ReviewManagementWebAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<ReviewDto, EditReviewViewModel>();
            CreateMap<CreateReviewViewModel, CreateReviewDto>();
            CreateMap<EditReviewViewModel, UpdateReviewDto>();
            
            CreateMap<ReviewDetailDto, EditReviewDetailViewModel>();
            CreateMap<CreateReviewDetailViewModel, CreateUpdateReviewDetailDto>();
            CreateMap<EditReviewDetailViewModel, CreateUpdateReviewDetailDto>();
        }
    }
}
