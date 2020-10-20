using System;
using EasyAbp.ReviewManagement.Reviews.Dtos;
using EasyAbp.ReviewManagement.Web.Pages.ReviewManagement.Reviews.Review.ViewModels;
using AutoMapper;
using Volo.Abp.AutoMapper;

namespace EasyAbp.ReviewManagement.Web
{
    public class ReviewManagementWebAutoMapperProfile : Profile
    {
        public ReviewManagementWebAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<ReviewDto, ReadReviewViewModel>()
                .ForMember(dest => dest.StarCount, opt => opt.MapFrom(src => Enum.Parse<StarCount>(src.StarCount.ToString()))); 
            CreateMap<ReviewDto, EditReviewViewModel>()
                .ForMember(dest => dest.StarCount, opt => opt.MapFrom(src => Enum.Parse<StarCount>(src.StarCount.ToString())));
            CreateMap<CreateReviewViewModel, CreateReviewDto>()
                .ForMember(dest => dest.StarCount, opt => opt.MapFrom(src => Convert.ToInt16(src.StarCount)))
                .Ignore(dto => dto.ExtraProperties);
            CreateMap<EditReviewViewModel, UpdateReviewDto>()
                .ForMember(dest => dest.StarCount, opt => opt.MapFrom(src => Convert.ToInt16(src.StarCount)))
                .Ignore(dto => dto.ExtraProperties); ;

            CreateMap<ReviewDetailDto, ReadReviewDetailViewModel>();
            CreateMap<ReviewDetailDto, EditReviewDetailViewModel>();
            CreateMap<CreateReviewDetailViewModel, CreateUpdateReviewDetailDto>();
            CreateMap<EditReviewDetailViewModel, CreateUpdateReviewDetailDto>();
        }
    }
}
