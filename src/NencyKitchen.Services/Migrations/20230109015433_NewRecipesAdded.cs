using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NencyKitchen.Services.Migrations
{
    /// <inheritdoc />
    public partial class NewRecipesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRecipeOfTheDay",
                table: "Recipes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "IsRecipeOfTheDay",
                value: true);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "IsRecipeOfTheDay",
                value: false);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "IsRecipeOfTheDay",
                value: true);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "IsRecipeOfTheDay",
                value: false);

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "ImageThumbnailUrl", "ImageUrl", "IsRecipeOfTheDay", "LongDescription", "RecipeName", "Serves", "ShortDescription" },
                values: new object[,]
                {
                    { 5, "https://iumerdbo.sirv.com/Nency/Riblje%20pljeskavice.jpg", "https://iumerdbo.sirv.com/Nency/Riblje%20pljeskavice.jpg", false, "Posne riblje pljeskavice pravljene od ribe lošijeg kvaliteta bez prethodnog okuvavanja ribe i gubljenja ukusa.Potrebna vam je mašina za mlevenje sa nožem broj tri ( to mi tata rekao ). Oni koji melju meso se verovatno razumeju koji je to nož.Pljeskavice su bile preukusne, pravio je duplu meru i pola dao nama, moja deca su se bukvalno “davila” u njima, a inače sem fileta neće ništa drugo ni da vide jer moraju da se bore sa kostima.", "Riblje pljeskavice", 4, "Ukusnije od junećih" },
                    { 6, "https://iumerdbo.sirv.com/Nency/Vafl-galete.jpg", "https://iumerdbo.sirv.com/Nency/Vafl-galete.jpg", true, "Pravila sam ja razne vafle i na razne načine, retke i guste smese, sa praškom za pecivo i sodom bikarbonom, sa uljem, maslacem, mašću, nema kako nisam, do ovog. Sada ga neću menjati i eksperimentisati, ovi su perfektni, mekani i sutradan ukoliko ih stavite u neku posudu da poklopcem ili u kesu, dugo baš drže svežinu, nisu previše slatki, tako da mogu da se dopunjavaju premazima i želeima od voća, a mogu da se grickaju i sami. Inače, recept je donešen iz škole, sa časa domaćinstva.", "Vafle – galete – bakin kolač", 8, "Mekani i fini i sutradan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "IsRecipeOfTheDay",
                table: "Recipes");
        }
    }
}
