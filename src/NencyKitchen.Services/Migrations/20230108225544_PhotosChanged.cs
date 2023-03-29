using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NencyKitchen.Services.Migrations
{
    /// <inheritdoc />
    public partial class PhotosChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://iumerdbo.sirv.com/Nency/Cokoladna%20torta.jpg", "https://iumerdbo.sirv.com/Nency/Cokoladna%20torta.jpg" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://iumerdbo.sirv.com/Nency/Lovacka%20snicla.jpg", "https://iumerdbo.sirv.com/Nency/Lovacka%20snicla.jpg" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://iumerdbo.sirv.com/Nency/Piletina%20tika%20masala.jpg", "https://iumerdbo.sirv.com/Nency/Piletina%20tika%20masala.jpg" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://iumerdbo.sirv.com/Nency/Pogaca.jpg", "https://iumerdbo.sirv.com/Nency/Pogaca.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://www.mybakingaddiction.com/wp-content/uploads/2011/10/lr-0968.jpg", "https://www.mybakingaddiction.com/wp-content/uploads/2011/10/lr-0968.jpg" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://domacirecepti.net/wp-content/uploads/2022/06/lovacke-krmenadle.jpg", "https://domacirecepti.net/wp-content/uploads/2022/06/lovacke-krmenadle.jpg" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://domacirecepti.net/wp-content/uploads/2022/11/tikka-masala-piletina.jpg", "https://domacirecepti.net/wp-content/uploads/2022/11/tikka-masala-piletina.jpg" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://mogujatosama.rs/sites/default/files/images/DSC04942.JPG", "https://mogujatosama.rs/sites/default/files/images/DSC04942.JPG" });
        }
    }
}
