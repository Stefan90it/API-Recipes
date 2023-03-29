using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NencyKitchen.DataModel.Entities;

namespace NencyKitchen.Services.DbContexts
{
    public class NencyKitchenDbContext : IdentityDbContext<IdentityUser>
    {
        public NencyKitchenDbContext(DbContextOptions<NencyKitchenDbContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<FoodCategory> Categories { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<RecipeStep> RecipeSteps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 1,
                RecipeName = "Kremisimo torta",
                ShortDescription = "Kremasti užitak za nepce",
                LongDescription = "Dve kakao korice, jedna meka od belanaca i fini krem od žumanaca i bele čokolada. Odlična spoj sočnih korica i laganog krema. Ova torta se nekada baš puno pravila, a sad je nekako u najezdi ovih novih, brzih torti pala u zaborav. Sada je pravo vreme da je podsetimo na nju.",
                ImageUrl = "https://iumerdbo.sirv.com/Nency/Cokoladna%20torta.jpg",
                ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Cokoladna%20torta.jpg",
                Serves = 16,
                IsRecipeOfTheDay = true

            });

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            { 
                RecipeId = 2, 
                RecipeName = "Lovačke krmenadle sa šampinjonima", 
                ShortDescription = "Baš pikantne krmenadle", 
                LongDescription = "Za sve ljubitelje ljutih djakonija ove krmenadle su kao stvorene. U isto vreme mekane i sočne, a ljute. Količinu ljute paprike možete i da smanjite, da napravite po vašem ukusu. Mi volimo da nas “reže” pa su nešto ljuće nego inače.", 
                ImageUrl = "https://iumerdbo.sirv.com/Nency/Lovacka%20snicla.jpg",
                ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Lovacka%20snicla.jpg", 
                Serves = 4,
                IsRecipeOfTheDay = false
            });

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            { 
                RecipeId = 3,
                RecipeName = "Piletina tikka masala", 
                ShortDescription = "Piletina na indijski način", 
                LongDescription = "Ako ste ljubitelj začina i kombinovanja više vrsta, kao i predivnog, gustog sosa, onda je ova kombinacija vaš pravi izbor. Prženo belo meso, tikka masala umak i pirinač. Za pola sata imaćete na vašem stolu brzo, lako, jednostavno i ukusno jelo.", 
                ImageUrl = "https://iumerdbo.sirv.com/Nency/Piletina%20tika%20masala.jpg",
                ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Piletina%20tika%20masala.jpg", 
                Serves = 4,
                IsRecipeOfTheDay = true
            });

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            { 
                RecipeId = 4,
                RecipeName = "Najlepša posna pogača",
                ShortDescription = "Uživaćete svim čulima",
                LongDescription = "Prelepa, dekorativna, posna pogača koja izgleda kao cvet. Već u prvim kadrovima možete videti koliko je ona mekana i vazdušasta, a o ukusu da ne pričam. Jeste da je sa margarinom koji mnogi ne odobravaju, ali kako su to uslovi posta onda je to tako i moralo biti. Obavezno je probajte, priprema je jedna od lakših i jednostavnijih, ne možete pogrešiti.",
                ImageUrl = "https://iumerdbo.sirv.com/Nency/Pogaca.jpg",
                ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Pogaca.jpg",
                Serves = 8,
                IsRecipeOfTheDay = false
            });

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 5,
                RecipeName = "Riblje pljeskavice",
                ShortDescription = "Ukusnije od junećih",
                LongDescription = "Posne riblje pljeskavice pravljene od ribe lošijeg kvaliteta bez prethodnog okuvavanja ribe i gubljenja ukusa.Potrebna vam je mašina za mlevenje sa nožem broj tri ( to mi tata rekao ). Oni koji melju meso se verovatno razumeju koji je to nož.Pljeskavice su bile preukusne, pravio je duplu meru i pola dao nama, moja deca su se bukvalno “davila” u njima, a inače sem fileta neće ništa drugo ni da vide jer moraju da se bore sa kostima.",
                ImageUrl = "https://iumerdbo.sirv.com/Nency/Riblje%20pljeskavice.jpg",
                ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Riblje%20pljeskavice.jpg",
                Serves = 4,
                IsRecipeOfTheDay = false
            });

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 40,
                RecipeName = "Vafle – galete – bakin kolač",
                ShortDescription = "Mekani i fini i sutradan",
                LongDescription = "Pravila sam ja razne vafle i na razne načine, retke i guste smese, sa praškom za pecivo i sodom bikarbonom, sa uljem, maslacem, mašću, nema kako nisam, do ovog. Sada ga neću menjati i eksperimentisati, ovi su perfektni, mekani i sutradan ukoliko ih stavite u neku posudu da poklopcem ili u kesu, dugo baš drže svežinu, nisu previše slatki, tako da mogu da se dopunjavaju premazima i želeima od voća, a mogu da se grickaju i sami. Inače, recept je donešen iz škole, sa časa domaćinstva.",
                ImageUrl = "https://iumerdbo.sirv.com/Nency/Vafl-galete.jpg",
                ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Vafl-galete.jpg",
                Serves = 8,
                IsRecipeOfTheDay = true,
            });

            modelBuilder.Entity<FoodCategory>().HasData(new FoodCategory { FoodCategoryId = 1, CategoryName = "Salate i predjela" });
            modelBuilder.Entity<FoodCategory>().HasData(new FoodCategory { FoodCategoryId = 2, CategoryName = "Hleb, pite i peciva" });
            modelBuilder.Entity<FoodCategory>().HasData(new FoodCategory { FoodCategoryId = 3, CategoryName = "Supe, čorbe i potaži" });
            modelBuilder.Entity<FoodCategory>().HasData(new FoodCategory { FoodCategoryId = 4, CategoryName = "Glavno jelo" });
            modelBuilder.Entity<FoodCategory>().HasData(new FoodCategory { FoodCategoryId = 5, CategoryName = "Jednostavni recepti" });
            modelBuilder.Entity<FoodCategory>().HasData(new FoodCategory { FoodCategoryId = 6, CategoryName = "Paste" });
            modelBuilder.Entity<FoodCategory>().HasData(new FoodCategory { FoodCategoryId = 7, CategoryName = "Napici i smoothie" });
            modelBuilder.Entity<FoodCategory>().HasData(new FoodCategory { FoodCategoryId = 8, CategoryName = "Kolači i torte" });

            modelBuilder.Entity<Course>().HasData(new Course { CourseId = 1, CourseName = "Doručak" });
            modelBuilder.Entity<Course>().HasData(new Course { CourseId = 2, CourseName = "Ručak" });
            modelBuilder.Entity<Course>().HasData(new Course { CourseId = 3, CourseName = "Večera" });
            modelBuilder.Entity<Course>().HasData(new Course { CourseId = 4, CourseName = "Užina" });
            modelBuilder.Entity<Course>().HasData(new Course { CourseId = 5, CourseName = "Poslastica" });

            modelBuilder.Entity<MeasurementUnit>().HasData(new MeasurementUnit { MeasurementUnitId = 0, MeasurementName = "" });
            modelBuilder.Entity<MeasurementUnit>().HasData(new MeasurementUnit { MeasurementUnitId = 1, MeasurementName = "Kašičica" });
            modelBuilder.Entity<MeasurementUnit>().HasData(new MeasurementUnit { MeasurementUnitId = 2, MeasurementName = "Kašika" });
            modelBuilder.Entity<MeasurementUnit>().HasData(new MeasurementUnit { MeasurementUnitId = 3, MeasurementName = "Šoljica" });
            modelBuilder.Entity<MeasurementUnit>().HasData(new MeasurementUnit { MeasurementUnitId = 4, MeasurementName = "Šolja" });
            modelBuilder.Entity<MeasurementUnit>().HasData(new MeasurementUnit { MeasurementUnitId = 5, MeasurementName = "Kesica" });
            modelBuilder.Entity<MeasurementUnit>().HasData(new MeasurementUnit { MeasurementUnitId = 6, MeasurementName = "ml" });
            modelBuilder.Entity<MeasurementUnit>().HasData(new MeasurementUnit { MeasurementUnitId = 7, MeasurementName = "l" });
            modelBuilder.Entity<MeasurementUnit>().HasData(new MeasurementUnit { MeasurementUnitId = 8, MeasurementName = "gr" });
            modelBuilder.Entity<MeasurementUnit>().HasData(new MeasurementUnit { MeasurementUnitId = 9, MeasurementName = "kg" });

            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 1, IngredientName = "Jaja" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 2, IngredientName = "Brašno" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 3, IngredientName = "Mleko" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 4, IngredientName = "Voda" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 5, IngredientName = "Kvasac" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 6, IngredientName = "Jagnjetina" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 7, IngredientName = "Svinjetina" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 8, IngredientName = "Piletina" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 9, IngredientName = "Krompir" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 10, IngredientName = "Ulje" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 11, IngredientName = "Šećer" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 12, IngredientName = "Griz" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 13, IngredientName = "Kakao" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 14, IngredientName = "Prašak za pecivo" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 15, IngredientName = "Belance" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 16, IngredientName = "Sirće" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 17, IngredientName = "Žumance" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 18, IngredientName = "Bela čokolada" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 19, IngredientName = "Margarin ili maslac" });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient { IngredientId = 20, IngredientName = "Šlag krem od vanile" });

            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 1, RecipeId = 1, QtyAmount = 6, MeasurementUnitId = 0, IngredientId = 1 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 2, RecipeId = 1, QtyAmount = 6, MeasurementUnitId = 2, IngredientId = 11 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 3, RecipeId = 1, QtyAmount = 2, MeasurementUnitId = 2, IngredientId = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 4, RecipeId = 1, QtyAmount = 2, MeasurementUnitId = 2, IngredientId = 12 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 5, RecipeId = 1, QtyAmount = 2, MeasurementUnitId = 2, IngredientId = 13 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 6, RecipeId = 1, QtyAmount = 10, MeasurementUnitId = 8, IngredientId = 14 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 7, RecipeId = 1, QtyAmount = 6, MeasurementUnitId = 0, IngredientId = 15 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 8, RecipeId = 1, QtyAmount = 10, MeasurementUnitId = 2, IngredientId = 11 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 9, RecipeId = 1, QtyAmount = 1, MeasurementUnitId = 1, IngredientId = 16 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 10, RecipeId = 1, QtyAmount = 1, MeasurementUnitId = 2, IngredientId = 2 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 11, RecipeId = 1, QtyAmount = 1, MeasurementUnitId = 2, IngredientId = 12 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 12, RecipeId = 1, QtyAmount = 6, MeasurementUnitId = 0, IngredientId = 17 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 13, RecipeId = 1, QtyAmount = 6, MeasurementUnitId = 2, IngredientId = 11 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 14, RecipeId = 1, QtyAmount = 200, MeasurementUnitId = 8, IngredientId = 18 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 15, RecipeId = 1, QtyAmount = 250, MeasurementUnitId = 8, IngredientId = 19 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 16, RecipeId = 1, QtyAmount = 50, MeasurementUnitId = 8, IngredientId = 20 });
            modelBuilder.Entity<RecipeIngredient>().HasData(new RecipeIngredient { RecipeIngredientId = 17, RecipeId = 1, QtyAmount = 100, MeasurementUnitId = 6, IngredientId = 3 });

            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 1, RecipeId = 1, StepNumber = 1, Instruction = "Uključiti rernu na 180 stepeni." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 2, RecipeId = 1, StepNumber = 2, Instruction = "Ulupat belanca sa šećerom, dodavati jedno po jedno žumance i mutiti." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 3, RecipeId = 1, StepNumber = 3, Instruction = "Dodati zatim prosejano brašno, griz i kakao uz prašak za pecivo." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 4, RecipeId = 1, StepNumber = 4, Instruction = "Izmešati i usuti u podmazan pleh prečnika 26cm pa staviti da se peče." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 5, RecipeId = 1, StepNumber = 5, Instruction = "Pečen biskvit ostaviti da se ohladi pa preseći na dva dela." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 6, RecipeId = 1, StepNumber = 6, Instruction = "Za belu koru ohladiti rernu na 160 stepeni." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 7, RecipeId = 1, StepNumber = 7, Instruction = "Ulupati belanca sa šećerom u čvrst sneg, dodati sirće i opet umutiti." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 8, RecipeId = 1, StepNumber = 8, Instruction = "Na kraju mešati kašiku brašna i kašiku griza." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 9, RecipeId = 1, StepNumber = 9, Instruction = "Istresti u isti pleh i kojem je pečena prva kora i staviti da se peče." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 10, RecipeId = 1, StepNumber = 10, Instruction = "Pečen biskvit ohladiti. Dok se bude pekao prvo će jako narasti a onda splasnuti i tako treba. Korica je na kraju veoma mekana." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 11, RecipeId = 1, StepNumber = 11, Instruction = "Za fil umutiti žumanca sa šećerom i staviti na paru da se kuva 10 minuta." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 12, RecipeId = 1, StepNumber = 12, Instruction = "Posle 10 minuta dodati belu čokoladu i mešati dok se čokolada ne otopi." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 13, RecipeId = 1, StepNumber = 13, Instruction = "Skloniti sa vatre i ostaviti da se ohladi uz povremeno mešanje." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 14, RecipeId = 1, StepNumber = 14, Instruction = "Umutiti maslaca, ddoati mu ohladjen krem i sve zajedno umutiti." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 15, RecipeId = 1, StepNumber = 15, Instruction = "Posebno izmiksirati mleko i šlag krem od vanile pa i njega dodati kremu i sve dobro sjediniti." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 16, RecipeId = 1, StepNumber = 16, Instruction = "Na tacnu staviti prvu koru, isprskati je mlekom pa naneti pola krema." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 17, RecipeId = 1, StepNumber = 17, Instruction = "Preko staviti  belu koru, isprskati je mlekom i naneti ostatak fila." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 18, RecipeId = 1, StepNumber = 18, Instruction = "Preklopiti sve drugom kakao korom koju takodje isprskamo mlekom." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 19, RecipeId = 1, StepNumber = 19, Instruction = "Ostaviti da se torta stegne pa je dekorisati, ili dekorisati odmah jer je torta prilično čvrsta." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 20, RecipeId = 1, StepNumber = 20, Instruction = "Dekoracija šlag krem čokolada." });
            modelBuilder.Entity<RecipeStep>().HasData(new RecipeStep { RecipeStepId = 21, RecipeId = 1, StepNumber = 21, Instruction = "Prijatno" });
        }
    }
}
