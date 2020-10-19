using System;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.ReviewManagement.Reviews.Dtos
{
    [Serializable]
    public class ReviewDetailDto : EntityDto<Guid>
    {
        public string Text { get; set; }

        public string MediaResources { get; set; }
    }
}