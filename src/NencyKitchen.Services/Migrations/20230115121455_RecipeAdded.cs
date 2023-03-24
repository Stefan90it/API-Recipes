using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NencyKitchen.Services.Migrations
{
    /// <inheritdoc />
    public partial class RecipeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "ImageThumbnailUrl", "ImageUrl", "IsRecipeOfTheDay", "LongDescription", "RecipeName", "Serves", "ShortDescription" },
                values: new object[] { 40, "https://iumerdbo.sirv.com/Nency/Vafl-galete.jpg", "https://iumerdbo.sirv.com/Nency/Vafl-galete.jpg", true, "Pravila sam ja razne vafle i na razne načine, retke i guste smese, sa praškom za pecivo i sodom bikarbonom, sa uljem, maslacem, mašću, nema kako nisam, do ovog. Sada ga neću menjati i eksperimentisati, ovi su perfektni, mekani i sutradan ukoliko ih stavite u neku posudu da poklopcem ili u kesu, dugo baš drže svežinu, nisu previše slatki, tako da mogu da se dopunjavaju premazima i želeima od voća, a mogu da se grickaju i sami. Inače, recept je donešen iz škole, sa časa domaćinstva.", "Vafle – galete – bakin kolač", 8, "Mekani i fini i sutradan" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 40);

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "ImageThumbnailUrl", "ImageUrl", "IsRecipeOfTheDay", "LongDescription", "RecipeName", "Serves", "ShortDescription" },
                values: new object[] { 6, "https://iumerdbo.sirv.com/Nency/Vafl-galete.jpg", "https://iumerdbo.sirv.com/Nency/Vafl-galete.jpg", true, "Pravila sam ja razne vafle i na razne načine, retke i guste smese, sa praškom za pecivo i sodom bikarbonom, sa uljem, maslacem, mašću, nema kako nisam, do ovog. Sada ga neću menjati i eksperimentisati, ovi su perfektni, mekani i sutradan ukoliko ih stavite u neku posudu da poklopcem ili u kesu, dugo baš drže svežinu, nisu previše slatki, tako da mogu da se dopunjavaju premazima i želeima od voća, a mogu da se grickaju i sami. Inače, recept je donešen iz škole, sa časa domaćinstva.", "Vafle – galete – bakin kolač", 8, "Mekani i fini i sutradan" });
        }
    }
}
