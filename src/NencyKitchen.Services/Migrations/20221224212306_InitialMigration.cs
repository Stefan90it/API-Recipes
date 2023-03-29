using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NencyKitchen.Services.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    FoodCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.FoodCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "MeasurementUnits",
                columns: table => new
                {
                    MeasurementUnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasurementName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementUnits", x => x.MeasurementUnitId);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serves = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    FoodCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                });

            migrationBuilder.CreateTable(
                name: "CourseRecipe",
                columns: table => new
                {
                    CoursesCourseId = table.Column<int>(type: "int", nullable: false),
                    RecipesRecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRecipe", x => new { x.CoursesCourseId, x.RecipesRecipeId });
                    table.ForeignKey(
                        name: "FK_CourseRecipe_Courses_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseRecipe_Recipes_RecipesRecipeId",
                        column: x => x.RecipesRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategoryRecipe",
                columns: table => new
                {
                    FoodCategoriesFoodCategoryId = table.Column<int>(type: "int", nullable: false),
                    RecipesRecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategoryRecipe", x => new { x.FoodCategoriesFoodCategoryId, x.RecipesRecipeId });
                    table.ForeignKey(
                        name: "FK_FoodCategoryRecipe_Categories_FoodCategoriesFoodCategoryId",
                        column: x => x.FoodCategoriesFoodCategoryId,
                        principalTable: "Categories",
                        principalColumn: "FoodCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodCategoryRecipe_Recipes_RecipesRecipeId",
                        column: x => x.RecipesRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeIngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    MeasurementUnitId = table.Column<int>(type: "int", nullable: true),
                    QtyAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.RecipeIngredientId);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_MeasurementUnits_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "MeasurementUnits",
                        principalColumn: "MeasurementUnitId");
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeSteps",
                columns: table => new
                {
                    RecipeStepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepNumber = table.Column<int>(type: "int", nullable: false),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeSteps", x => x.RecipeStepId);
                    table.ForeignKey(
                        name: "FK_RecipeSteps_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "FoodCategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Salate i predjela" },
                    { 2, "Hleb, pite i peciva" },
                    { 3, "Supe, čorbe i potaži" },
                    { 4, "Glavno jelo" },
                    { 5, "Jednostavni recepti" },
                    { 6, "Paste" },
                    { 7, "Napici i smoothie" },
                    { 8, "Kolači i torte" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName" },
                values: new object[,]
                {
                    { 1, "Doručak" },
                    { 2, "Ručak" },
                    { 3, "Večera" },
                    { 4, "Užina" },
                    { 5, "Poslastica" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "IngredientName" },
                values: new object[,]
                {
                    { 1, "Jaja" },
                    { 2, "Brašno" },
                    { 3, "Mleko" },
                    { 4, "Voda" },
                    { 5, "Kvasac" },
                    { 6, "Jagnjetina" },
                    { 7, "Svinjetina" },
                    { 8, "Piletina" },
                    { 9, "Krompir" },
                    { 10, "Ulje" },
                    { 11, "Šećer" },
                    { 12, "Griz" },
                    { 13, "Kakao" },
                    { 14, "Prašak za pecivo" },
                    { 15, "Belance" },
                    { 16, "Sirće" },
                    { 17, "Žumance" },
                    { 18, "Bela čokolada" },
                    { 19, "Margarin ili maslac" },
                    { 20, "Šlag krem od vanile" }
                });

            migrationBuilder.InsertData(
                table: "MeasurementUnits",
                columns: new[] { "MeasurementUnitId", "MeasurementName" },
                values: new object[,]
                {
                    { 1, "Kašičica" },
                    { 2, "Kašika" },
                    { 3, "Šoljica" },
                    { 4, "Šolja" },
                    { 5, "Kesica" },
                    { 6, "ml" },
                    { 7, "l" },
                    { 8, "gr" },
                    { 9, "kg" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CourseId", "FoodCategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "RecipeName", "Serves", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 5, 8, "https://www.mybakingaddiction.com/wp-content/uploads/2011/10/lr-0968.jpg", "https://www.mybakingaddiction.com/wp-content/uploads/2011/10/lr-0968.jpg", "Dve kakao korice, jedna meka od belanaca i fini krem od žumanaca i bele čokolada. Odlična spoj sočnih korica i laganog krema. Ova torta se nekada baš puno pravila, a sad je nekako u najezdi ovih novih, brzih torti pala u zaborav. Sada je pravo vreme da je podsetimo na nju.", "Kremisimo torta", 16, "Kremasti užitak za nepce" },
                    { 2, 2, 4, "https://domacirecepti.net/wp-content/uploads/2022/06/lovacke-krmenadle.jpg", "https://domacirecepti.net/wp-content/uploads/2022/06/lovacke-krmenadle.jpg", "Za sve ljubitelje ljutih djakonija ove krmenadle su kao stvorene. U isto vreme mekane i sočne, a ljute. Količinu ljute paprike možete i da smanjite, da napravite po vašem ukusu. Mi volimo da nas “reže” pa su nešto ljuće nego inače.", "Lovačke krmenadle sa šampinjonima", 4, "Baš pikantne krmenadle" },
                    { 3, 2, 4, "https://domacirecepti.net/wp-content/uploads/2022/11/tikka-masala-piletina.jpg", "https://domacirecepti.net/wp-content/uploads/2022/11/tikka-masala-piletina.jpg", "Ako ste ljubitelj začina i kombinovanja više vrsta, kao i predivnog, gustog sosa, onda je ova kombinacija vaš pravi izbor. Prženo belo meso, tikka masala umak i pirinač. Za pola sata imaćete na vašem stolu brzo, lako, jednostavno i ukusno jelo.", "Piletina tikka masala", 4, "Piletina na indijski način" },
                    { 4, 2, 2, "https://mogujatosama.rs/sites/default/files/images/DSC04942.JPG", "https://mogujatosama.rs/sites/default/files/images/DSC04942.JPG", "Prelepa, dekorativna, posna pogača koja izgleda kao cvet. Već u prvim kadrovima možete videti koliko je ona mekana i vazdušasta, a o ukusu da ne pričam. Jeste da je sa margarinom koji mnogi ne odobravaju, ali kako su to uslovi posta onda je to tako i moralo biti. Obavezno je probajte, priprema je jedna od lakših i jednostavnijih, ne možete pogrešiti.", "Najlepša posna pogača", 8, "Uživaćete svim čulima" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "RecipeIngredientId", "IngredientId", "MeasurementUnitId", "QtyAmount", "RecipeId" },
                values: new object[,]
                {
                    { 1, 1, null, 6.0, 1 },
                    { 2, 11, 2, 6.0, 1 },
                    { 3, 2, 2, 2.0, 1 },
                    { 4, 12, 2, 2.0, 1 },
                    { 5, 13, 2, 2.0, 1 },
                    { 6, 14, 8, 10.0, 1 },
                    { 7, 15, null, 6.0, 1 },
                    { 8, 11, 2, 10.0, 1 },
                    { 9, 16, 1, 1.0, 1 },
                    { 10, 2, 2, 1.0, 1 },
                    { 11, 12, 2, 1.0, 1 },
                    { 12, 17, null, 6.0, 1 },
                    { 13, 11, 2, 6.0, 1 },
                    { 14, 18, 8, 200.0, 1 },
                    { 15, 19, 8, 250.0, 1 },
                    { 16, 20, 8, 50.0, 1 },
                    { 17, 3, 6, 100.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeSteps",
                columns: new[] { "RecipeStepId", "Instruction", "RecipeId", "StepNumber" },
                values: new object[,]
                {
                    { 1, "Uključiti rernu na 180 stepeni.", 1, 1 },
                    { 2, "Ulupat belanca sa šećerom, dodavati jedno po jedno žumance i mutiti.", 1, 2 },
                    { 3, "Dodati zatim prosejano brašno, griz i kakao uz prašak za pecivo.", 1, 3 },
                    { 4, "Izmešati i usuti u podmazan pleh prečnika 26cm pa staviti da se peče.", 1, 4 },
                    { 5, "Pečen biskvit ostaviti da se ohladi pa preseći na dva dela.", 1, 5 },
                    { 6, "Za belu koru ohladiti rernu na 160 stepeni.", 1, 6 },
                    { 7, "Ulupati belanca sa šećerom u čvrst sneg, dodati sirće i opet umutiti.", 1, 7 },
                    { 8, "Na kraju mešati kašiku brašna i kašiku griza.", 1, 8 },
                    { 9, "Istresti u isti pleh i kojem je pečena prva kora i staviti da se peče.", 1, 9 },
                    { 10, "Pečen biskvit ohladiti. Dok se bude pekao prvo će jako narasti a onda splasnuti i tako treba. Korica je na kraju veoma mekana.", 1, 10 },
                    { 11, "Za fil umutiti žumanca sa šećerom i staviti na paru da se kuva 10 minuta.", 1, 11 },
                    { 12, "Posle 10 minuta dodati belu čokoladu i mešati dok se čokolada ne otopi.", 1, 12 },
                    { 13, "Skloniti sa vatre i ostaviti da se ohladi uz povremeno mešanje.", 1, 13 },
                    { 14, "Umutiti maslaca, ddoati mu ohladjen krem i sve zajedno umutiti.", 1, 14 },
                    { 15, "Posebno izmiksirati mleko i šlag krem od vanile pa i njega dodati kremu i sve dobro sjediniti.", 1, 15 },
                    { 16, "Na tacnu staviti prvu koru, isprskati je mlekom pa naneti pola krema.", 1, 16 },
                    { 17, "Preko staviti  belu koru, isprskati je mlekom i naneti ostatak fila.", 1, 17 },
                    { 18, "Preklopiti sve drugom kakao korom koju takodje isprskamo mlekom.", 1, 18 },
                    { 19, "Ostaviti da se torta stegne pa je dekorisati, ili dekorisati odmah jer je torta prilično čvrsta.", 1, 19 },
                    { 20, "Dekoracija šlag krem čokolada.", 1, 20 },
                    { 21, "Prijatno", 1, 21 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRecipe_RecipesRecipeId",
                table: "CourseRecipe",
                column: "RecipesRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategoryRecipe_RecipesRecipeId",
                table: "FoodCategoryRecipe",
                column: "RecipesRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_MeasurementUnitId",
                table: "RecipeIngredients",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeSteps_RecipeId",
                table: "RecipeSteps",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseRecipe");

            migrationBuilder.DropTable(
                name: "FoodCategoryRecipe");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "RecipeSteps");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "MeasurementUnits");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
