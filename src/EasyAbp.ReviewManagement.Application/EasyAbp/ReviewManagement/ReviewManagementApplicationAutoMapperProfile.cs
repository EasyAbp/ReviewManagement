using EasyAbp.ReviewManagement.Reviews;
using EasyAbp.ReviewManagement.Reviews.Dtos;
using AutoMapper;

namespace EasyAbp.ReviewManagement
{
    public class ReviewManagementApplicationAutoMapperProfile : Profile
    {
        public ReviewManagementApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Review, ReviewDto>();
            CreateMap<CreateReviewDto, Review>(MemberList.Source);
            CreateMap<UpdateReviewDto, Review>(MemberList.Source);
            CreateMap<ReviewDetail, ReviewDetailDto>();
            CreateMap<CreateUpdateReviewDetailDto, ReviewDetail>(MemberList.Source);
        }
    }
}
