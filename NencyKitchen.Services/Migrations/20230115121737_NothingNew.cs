using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NencyKitchen.Services.Migrations
{
    /// <inheritdoc />
    public partial class NothingNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "RecipeIngredientId",
                keyValue: 1,
                column: "MeasurementUnitId",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "RecipeIngredientId",
                keyValue: 1,
                column: "MeasurementUnitId",
                value: null);
        }
    }
}
