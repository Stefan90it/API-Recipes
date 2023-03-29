using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NencyKitchen.Services.Migrations
{
    /// <inheritdoc />
    public partial class RecipeTableChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "FoodCategoryId",
                table: "Recipes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoodCategoryId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "CourseId", "FoodCategoryId" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "CourseId", "FoodCategoryId" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                columns: new[] { "CourseId", "FoodCategoryId" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                columns: new[] { "CourseId", "FoodCategoryId" },
                values: new object[] { 2, 2 });
        }
    }
}
