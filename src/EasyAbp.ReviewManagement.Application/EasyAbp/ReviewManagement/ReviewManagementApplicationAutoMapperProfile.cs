using EasyAbp.ReviewManagement.Reviews;
using EasyAbp.ReviewManagement.Reviews.Dtos;
using AutoMapper;
using Volo.Abp.AutoMapper;

namespace EasyAbp.ReviewManagement
{
    public class ReviewManagementApplicationAutoMapperProfile : Profile
    {
        public ReviewManagementApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Review, ReviewDto>()
                .Ignore(dto => dto.CreatorUserName);
            CreateMap<ReviewDetail, ReviewDetailDto>();
        }
    }
}
