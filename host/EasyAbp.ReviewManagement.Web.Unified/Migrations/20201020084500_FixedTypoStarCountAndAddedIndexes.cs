using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyAbp.ReviewManagement.Web.Unified.Migrations
{
    public partial class FixedTypoStarCountAndAddedIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartCount",
                table: "EasyAbpReviewManagementReviews");

            migrationBuilder.AlterColumn<string>(
                name: "EntityType",
                table: "EasyAbpReviewManagementReviews",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EntityId",
                table: "EasyAbpReviewManagementReviews",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<short>(
                name: "StarCount",
                table: "EasyAbpReviewManagementReviews",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "EasyAbpReviewManagementReviewDetails",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MediaResources",
                table: "EasyAbpReviewManagementReviewDetails",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EasyAbpReviewManagementReviews_TenantId_EntityType_EntityId_IsPublic",
                table: "EasyAbpReviewManagementReviews",
                columns: new[] { "TenantId", "EntityType", "EntityId", "IsPublic" });

            migrationBuilder.CreateIndex(
                name: "IX_EasyAbpReviewManagementReviews_TenantId_CreatorId_EntityType_EntityId_IsPublic",
                table: "EasyAbpReviewManagementReviews",
                columns: new[] { "TenantId", "CreatorId", "EntityType", "EntityId", "IsPublic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EasyAbpReviewManagementReviews_TenantId_EntityType_EntityId_IsPublic",
                table: "EasyAbpReviewManagementReviews");

            migrationBuilder.DropIndex(
                name: "IX_EasyAbpReviewManagementReviews_TenantId_CreatorId_EntityType_EntityId_IsPublic",
                table: "EasyAbpReviewManagementReviews");

            migrationBuilder.DropColumn(
                name: "StarCount",
                table: "EasyAbpReviewManagementReviews");

            migrationBuilder.AlterColumn<string>(
                name: "EntityType",
                table: "EasyAbpReviewManagementReviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "EntityId",
                table: "EasyAbpReviewManagementReviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AddColumn<short>(
                name: "StartCount",
                table: "EasyAbpReviewManagementReviews",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "EasyAbpReviewManagementReviewDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MediaResources",
                table: "EasyAbpReviewManagementReviewDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1024,
                oldNullable: true);
        }
    }
}
