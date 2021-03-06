using EasyAbp.ReviewManagement.Reviews;
using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EasyAbp.ReviewManagement.EntityFrameworkCore
{
    public static class ReviewManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureReviewManagement(
            this ModelBuilder builder,
            Action<ReviewManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ReviewManagementModelBuilderConfigurationOptions(
                ReviewManagementDbProperties.DbTablePrefix,
                ReviewManagementDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */


            builder.Entity<Review>(b =>
            {
                b.ToTable(options.TablePrefix + "Reviews", options.Schema);
                b.ConfigureByConvention(); 
                
                /* Configure more properties here */
                
                b.Property(x => x.EntityType).IsRequired().HasMaxLength(ReviewConsts.MaxEntityTypeLength);
                b.Property(x => x.EntityId).IsRequired().HasMaxLength(ReviewConsts.MaxEntityIdLength);
                b.Property(x => x.IsPublic).IsRequired();
                b.Property(x => x.StarCount).IsRequired();

                b.HasIndex(x => new { x.TenantId, x.EntityType, x.EntityId, x.IsPublic });
                b.HasIndex(x => new { x.TenantId, x.CreatorId, x.EntityType, x.EntityId, x.IsPublic });

                b.HasOne(x => x.ReviewDetail);
            });


            builder.Entity<ReviewDetail>(b =>
            {
                b.ToTable(options.TablePrefix + "ReviewDetails", options.Schema);
                b.ConfigureByConvention();

                /* Configure more properties here */
                b.Property(x => x.Text).HasMaxLength(ReviewConsts.MaxTextLength);
                b.Property(x => x.MediaResources).HasMaxLength(ReviewConsts.MaxMediaResourcesLength);
            });
        }
    }
}
