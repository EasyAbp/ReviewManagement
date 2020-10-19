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
            });


            builder.Entity<ReviewDetail>(b =>
            {
                b.ToTable(options.TablePrefix + "ReviewDetails", options.Schema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
        }
    }
}
