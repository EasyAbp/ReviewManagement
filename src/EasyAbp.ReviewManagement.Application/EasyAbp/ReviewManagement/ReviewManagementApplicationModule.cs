﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.Users;

namespace EasyAbp.ReviewManagement
{
    [DependsOn(
        typeof(ReviewManagementDomainModule),
        typeof(ReviewManagementApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpUsersAbstractionModule)
    )]
    public class ReviewManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<ReviewManagementApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ReviewManagementApplicationModule>(validate: true);
            });
        }
    }
}
