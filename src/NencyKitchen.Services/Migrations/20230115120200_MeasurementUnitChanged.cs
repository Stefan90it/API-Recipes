using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NencyKitchen.Services.Migrations
{
    /// <inheritdoc />
    public partial class MeasurementUnitChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeasurementName",
                table: "MeasurementUnits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "MeasurementUnits",
                columns: new[] { "MeasurementUnitId", "MeasurementName" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "RecipeIngredientId",
                keyValue: 7,
                column: "MeasurementUnitId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "RecipeIngredientId",
                keyValue: 12,
                column: "MeasurementUnitId",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "MeasurementUnitId",
                keyValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "MeasurementName",
                table: "MeasurementUnits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "RecipeIngredientId",
                keyValue: 7,
                column: "MeasurementUnitId",
                value: null);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumn: "RecipeIngredientId",
                keyValue: 12,
                column: "MeasurementUnitId",
                value: null);
        }
    }
}
