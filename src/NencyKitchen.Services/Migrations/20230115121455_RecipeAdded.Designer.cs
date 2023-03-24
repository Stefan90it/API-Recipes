﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NencyKitchen.Services.DbContexts;

#nullable disable

namespace NencyKitchen.Services.Migrations
{
    [DbContext(typeof(NencyKitchenDbContext))]
    [Migration("20230115121455_RecipeAdded")]
    partial class RecipeAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseRecipe", b =>
                {
                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("RecipesRecipeId")
                        .HasColumnType("int");

                    b.HasKey("CoursesCourseId", "RecipesRecipeId");

                    b.HasIndex("RecipesRecipeId");

                    b.ToTable("CourseRecipe");
                });

            modelBuilder.Entity("FoodCategoryRecipe", b =>
                {
                    b.Property<int>("FoodCategoriesFoodCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("RecipesRecipeId")
                        .HasColumnType("int");

                    b.HasKey("FoodCategoriesFoodCategoryId", "RecipesRecipeId");

                    b.HasIndex("RecipesRecipeId");

                    b.ToTable("FoodCategoryRecipe");
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "Doručak"
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Ručak"
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "Večera"
                        },
                        new
                        {
                            CourseId = 4,
                            CourseName = "Užina"
                        },
                        new
                        {
                            CourseId = 5,
                            CourseName = "Poslastica"
                        });
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.FoodCategory", b =>
                {
                    b.Property<int>("FoodCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodCategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FoodCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            FoodCategoryId = 1,
                            CategoryName = "Salate i predjela"
                        },
                        new
                        {
                            FoodCategoryId = 2,
                            CategoryName = "Hleb, pite i peciva"
                        },
                        new
                        {
                            FoodCategoryId = 3,
                            CategoryName = "Supe, čorbe i potaži"
                        },
                        new
                        {
                            FoodCategoryId = 4,
                            CategoryName = "Glavno jelo"
                        },
                        new
                        {
                            FoodCategoryId = 5,
                            CategoryName = "Jednostavni recepti"
                        },
                        new
                        {
                            FoodCategoryId = 6,
                            CategoryName = "Paste"
                        },
                        new
                        {
                            FoodCategoryId = 7,
                            CategoryName = "Napici i smoothie"
                        },
                        new
                        {
                            FoodCategoryId = 8,
                            CategoryName = "Kolači i torte"
                        });
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"));

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            IngredientName = "Jaja"
                        },
                        new
                        {
                            IngredientId = 2,
                            IngredientName = "Brašno"
                        },
                        new
                        {
                            IngredientId = 3,
                            IngredientName = "Mleko"
                        },
                        new
                        {
                            IngredientId = 4,
                            IngredientName = "Voda"
                        },
                        new
                        {
                            IngredientId = 5,
                            IngredientName = "Kvasac"
                        },
                        new
                        {
                            IngredientId = 6,
                            IngredientName = "Jagnjetina"
                        },
                        new
                        {
                            IngredientId = 7,
                            IngredientName = "Svinjetina"
                        },
                        new
                        {
                            IngredientId = 8,
                            IngredientName = "Piletina"
                        },
                        new
                        {
                            IngredientId = 9,
                            IngredientName = "Krompir"
                        },
                        new
                        {
                            IngredientId = 10,
                            IngredientName = "Ulje"
                        },
                        new
                        {
                            IngredientId = 11,
                            IngredientName = "Šećer"
                        },
                        new
                        {
                            IngredientId = 12,
                            IngredientName = "Griz"
                        },
                        new
                        {
                            IngredientId = 13,
                            IngredientName = "Kakao"
                        },
                        new
                        {
                            IngredientId = 14,
                            IngredientName = "Prašak za pecivo"
                        },
                        new
                        {
                            IngredientId = 15,
                            IngredientName = "Belance"
                        },
                        new
                        {
                            IngredientId = 16,
                            IngredientName = "Sirće"
                        },
                        new
                        {
                            IngredientId = 17,
                            IngredientName = "Žumance"
                        },
                        new
                        {
                            IngredientId = 18,
                            IngredientName = "Bela čokolada"
                        },
                        new
                        {
                            IngredientId = 19,
                            IngredientName = "Margarin ili maslac"
                        },
                        new
                        {
                            IngredientId = 20,
                            IngredientName = "Šlag krem od vanile"
                        });
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.MeasurementUnit", b =>
                {
                    b.Property<int?>("MeasurementUnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("MeasurementUnitId"));

                    b.Property<string>("MeasurementName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MeasurementUnitId");

                    b.ToTable("MeasurementUnits");

                    b.HasData(
                        new
                        {
                            MeasurementUnitId = 0,
                            MeasurementName = ""
                        },
                        new
                        {
                            MeasurementUnitId = 1,
                            MeasurementName = "Kašičica"
                        },
                        new
                        {
                            MeasurementUnitId = 2,
                            MeasurementName = "Kašika"
                        },
                        new
                        {
                            MeasurementUnitId = 3,
                            MeasurementName = "Šoljica"
                        },
                        new
                        {
                            MeasurementUnitId = 4,
                            MeasurementName = "Šolja"
                        },
                        new
                        {
                            MeasurementUnitId = 5,
                            MeasurementName = "Kesica"
                        },
                        new
                        {
                            MeasurementUnitId = 6,
                            MeasurementName = "ml"
                        },
                        new
                        {
                            MeasurementUnitId = 7,
                            MeasurementName = "l"
                        },
                        new
                        {
                            MeasurementUnitId = 8,
                            MeasurementName = "gr"
                        },
                        new
                        {
                            MeasurementUnitId = 9,
                            MeasurementName = "kg"
                        });
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"));

                    b.Property<string>("ImageThumbnailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRecipeOfTheDay")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Serves")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Cokoladna%20torta.jpg",
                            ImageUrl = "https://iumerdbo.sirv.com/Nency/Cokoladna%20torta.jpg",
                            IsRecipeOfTheDay = true,
                            LongDescription = "Dve kakao korice, jedna meka od belanaca i fini krem od žumanaca i bele čokolada. Odlična spoj sočnih korica i laganog krema. Ova torta se nekada baš puno pravila, a sad je nekako u najezdi ovih novih, brzih torti pala u zaborav. Sada je pravo vreme da je podsetimo na nju.",
                            RecipeName = "Kremisimo torta",
                            Serves = 16,
                            ShortDescription = "Kremasti užitak za nepce"
                        },
                        new
                        {
                            RecipeId = 2,
                            ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Lovacka%20snicla.jpg",
                            ImageUrl = "https://iumerdbo.sirv.com/Nency/Lovacka%20snicla.jpg",
                            IsRecipeOfTheDay = false,
                            LongDescription = "Za sve ljubitelje ljutih djakonija ove krmenadle su kao stvorene. U isto vreme mekane i sočne, a ljute. Količinu ljute paprike možete i da smanjite, da napravite po vašem ukusu. Mi volimo da nas “reže” pa su nešto ljuće nego inače.",
                            RecipeName = "Lovačke krmenadle sa šampinjonima",
                            Serves = 4,
                            ShortDescription = "Baš pikantne krmenadle"
                        },
                        new
                        {
                            RecipeId = 3,
                            ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Piletina%20tika%20masala.jpg",
                            ImageUrl = "https://iumerdbo.sirv.com/Nency/Piletina%20tika%20masala.jpg",
                            IsRecipeOfTheDay = true,
                            LongDescription = "Ako ste ljubitelj začina i kombinovanja više vrsta, kao i predivnog, gustog sosa, onda je ova kombinacija vaš pravi izbor. Prženo belo meso, tikka masala umak i pirinač. Za pola sata imaćete na vašem stolu brzo, lako, jednostavno i ukusno jelo.",
                            RecipeName = "Piletina tikka masala",
                            Serves = 4,
                            ShortDescription = "Piletina na indijski način"
                        },
                        new
                        {
                            RecipeId = 4,
                            ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Pogaca.jpg",
                            ImageUrl = "https://iumerdbo.sirv.com/Nency/Pogaca.jpg",
                            IsRecipeOfTheDay = false,
                            LongDescription = "Prelepa, dekorativna, posna pogača koja izgleda kao cvet. Već u prvim kadrovima možete videti koliko je ona mekana i vazdušasta, a o ukusu da ne pričam. Jeste da je sa margarinom koji mnogi ne odobravaju, ali kako su to uslovi posta onda je to tako i moralo biti. Obavezno je probajte, priprema je jedna od lakših i jednostavnijih, ne možete pogrešiti.",
                            RecipeName = "Najlepša posna pogača",
                            Serves = 8,
                            ShortDescription = "Uživaćete svim čulima"
                        },
                        new
                        {
                            RecipeId = 5,
                            ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Riblje%20pljeskavice.jpg",
                            ImageUrl = "https://iumerdbo.sirv.com/Nency/Riblje%20pljeskavice.jpg",
                            IsRecipeOfTheDay = false,
                            LongDescription = "Posne riblje pljeskavice pravljene od ribe lošijeg kvaliteta bez prethodnog okuvavanja ribe i gubljenja ukusa.Potrebna vam je mašina za mlevenje sa nožem broj tri ( to mi tata rekao ). Oni koji melju meso se verovatno razumeju koji je to nož.Pljeskavice su bile preukusne, pravio je duplu meru i pola dao nama, moja deca su se bukvalno “davila” u njima, a inače sem fileta neće ništa drugo ni da vide jer moraju da se bore sa kostima.",
                            RecipeName = "Riblje pljeskavice",
                            Serves = 4,
                            ShortDescription = "Ukusnije od junećih"
                        },
                        new
                        {
                            RecipeId = 40,
                            ImageThumbnailUrl = "https://iumerdbo.sirv.com/Nency/Vafl-galete.jpg",
                            ImageUrl = "https://iumerdbo.sirv.com/Nency/Vafl-galete.jpg",
                            IsRecipeOfTheDay = true,
                            LongDescription = "Pravila sam ja razne vafle i na razne načine, retke i guste smese, sa praškom za pecivo i sodom bikarbonom, sa uljem, maslacem, mašću, nema kako nisam, do ovog. Sada ga neću menjati i eksperimentisati, ovi su perfektni, mekani i sutradan ukoliko ih stavite u neku posudu da poklopcem ili u kesu, dugo baš drže svežinu, nisu previše slatki, tako da mogu da se dopunjavaju premazima i želeima od voća, a mogu da se grickaju i sami. Inače, recept je donešen iz škole, sa časa domaćinstva.",
                            RecipeName = "Vafle – galete – bakin kolač",
                            Serves = 8,
                            ShortDescription = "Mekani i fini i sutradan"
                        });
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeIngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeIngredientId"));

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int?>("MeasurementUnitId")
                        .HasColumnType("int");

                    b.Property<double>("QtyAmount")
                        .HasColumnType("float");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("RecipeIngredientId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("MeasurementUnitId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            RecipeIngredientId = 1,
                            IngredientId = 1,
                            QtyAmount = 6.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 2,
                            IngredientId = 11,
                            MeasurementUnitId = 2,
                            QtyAmount = 6.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 3,
                            IngredientId = 2,
                            MeasurementUnitId = 2,
                            QtyAmount = 2.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 4,
                            IngredientId = 12,
                            MeasurementUnitId = 2,
                            QtyAmount = 2.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 5,
                            IngredientId = 13,
                            MeasurementUnitId = 2,
                            QtyAmount = 2.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 6,
                            IngredientId = 14,
                            MeasurementUnitId = 8,
                            QtyAmount = 10.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 7,
                            IngredientId = 15,
                            MeasurementUnitId = 0,
                            QtyAmount = 6.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 8,
                            IngredientId = 11,
                            MeasurementUnitId = 2,
                            QtyAmount = 10.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 9,
                            IngredientId = 16,
                            MeasurementUnitId = 1,
                            QtyAmount = 1.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 10,
                            IngredientId = 2,
                            MeasurementUnitId = 2,
                            QtyAmount = 1.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 11,
                            IngredientId = 12,
                            MeasurementUnitId = 2,
                            QtyAmount = 1.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 12,
                            IngredientId = 17,
                            MeasurementUnitId = 0,
                            QtyAmount = 6.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 13,
                            IngredientId = 11,
                            MeasurementUnitId = 2,
                            QtyAmount = 6.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 14,
                            IngredientId = 18,
                            MeasurementUnitId = 8,
                            QtyAmount = 200.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 15,
                            IngredientId = 19,
                            MeasurementUnitId = 8,
                            QtyAmount = 250.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 16,
                            IngredientId = 20,
                            MeasurementUnitId = 8,
                            QtyAmount = 50.0,
                            RecipeId = 1
                        },
                        new
                        {
                            RecipeIngredientId = 17,
                            IngredientId = 3,
                            MeasurementUnitId = 6,
                            QtyAmount = 100.0,
                            RecipeId = 1
                        });
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.RecipeStep", b =>
                {
                    b.Property<int>("RecipeStepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeStepId"));

                    b.Property<string>("Instruction")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("StepNumber")
                        .HasColumnType("int");

                    b.HasKey("RecipeStepId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeSteps");

                    b.HasData(
                        new
                        {
                            RecipeStepId = 1,
                            Instruction = "Uključiti rernu na 180 stepeni.",
                            RecipeId = 1,
                            StepNumber = 1
                        },
                        new
                        {
                            RecipeStepId = 2,
                            Instruction = "Ulupat belanca sa šećerom, dodavati jedno po jedno žumance i mutiti.",
                            RecipeId = 1,
                            StepNumber = 2
                        },
                        new
                        {
                            RecipeStepId = 3,
                            Instruction = "Dodati zatim prosejano brašno, griz i kakao uz prašak za pecivo.",
                            RecipeId = 1,
                            StepNumber = 3
                        },
                        new
                        {
                            RecipeStepId = 4,
                            Instruction = "Izmešati i usuti u podmazan pleh prečnika 26cm pa staviti da se peče.",
                            RecipeId = 1,
                            StepNumber = 4
                        },
                        new
                        {
                            RecipeStepId = 5,
                            Instruction = "Pečen biskvit ostaviti da se ohladi pa preseći na dva dela.",
                            RecipeId = 1,
                            StepNumber = 5
                        },
                        new
                        {
                            RecipeStepId = 6,
                            Instruction = "Za belu koru ohladiti rernu na 160 stepeni.",
                            RecipeId = 1,
                            StepNumber = 6
                        },
                        new
                        {
                            RecipeStepId = 7,
                            Instruction = "Ulupati belanca sa šećerom u čvrst sneg, dodati sirće i opet umutiti.",
                            RecipeId = 1,
                            StepNumber = 7
                        },
                        new
                        {
                            RecipeStepId = 8,
                            Instruction = "Na kraju mešati kašiku brašna i kašiku griza.",
                            RecipeId = 1,
                            StepNumber = 8
                        },
                        new
                        {
                            RecipeStepId = 9,
                            Instruction = "Istresti u isti pleh i kojem je pečena prva kora i staviti da se peče.",
                            RecipeId = 1,
                            StepNumber = 9
                        },
                        new
                        {
                            RecipeStepId = 10,
                            Instruction = "Pečen biskvit ohladiti. Dok se bude pekao prvo će jako narasti a onda splasnuti i tako treba. Korica je na kraju veoma mekana.",
                            RecipeId = 1,
                            StepNumber = 10
                        },
                        new
                        {
                            RecipeStepId = 11,
                            Instruction = "Za fil umutiti žumanca sa šećerom i staviti na paru da se kuva 10 minuta.",
                            RecipeId = 1,
                            StepNumber = 11
                        },
                        new
                        {
                            RecipeStepId = 12,
                            Instruction = "Posle 10 minuta dodati belu čokoladu i mešati dok se čokolada ne otopi.",
                            RecipeId = 1,
                            StepNumber = 12
                        },
                        new
                        {
                            RecipeStepId = 13,
                            Instruction = "Skloniti sa vatre i ostaviti da se ohladi uz povremeno mešanje.",
                            RecipeId = 1,
                            StepNumber = 13
                        },
                        new
                        {
                            RecipeStepId = 14,
                            Instruction = "Umutiti maslaca, ddoati mu ohladjen krem i sve zajedno umutiti.",
                            RecipeId = 1,
                            StepNumber = 14
                        },
                        new
                        {
                            RecipeStepId = 15,
                            Instruction = "Posebno izmiksirati mleko i šlag krem od vanile pa i njega dodati kremu i sve dobro sjediniti.",
                            RecipeId = 1,
                            StepNumber = 15
                        },
                        new
                        {
                            RecipeStepId = 16,
                            Instruction = "Na tacnu staviti prvu koru, isprskati je mlekom pa naneti pola krema.",
                            RecipeId = 1,
                            StepNumber = 16
                        },
                        new
                        {
                            RecipeStepId = 17,
                            Instruction = "Preko staviti  belu koru, isprskati je mlekom i naneti ostatak fila.",
                            RecipeId = 1,
                            StepNumber = 17
                        },
                        new
                        {
                            RecipeStepId = 18,
                            Instruction = "Preklopiti sve drugom kakao korom koju takodje isprskamo mlekom.",
                            RecipeId = 1,
                            StepNumber = 18
                        },
                        new
                        {
                            RecipeStepId = 19,
                            Instruction = "Ostaviti da se torta stegne pa je dekorisati, ili dekorisati odmah jer je torta prilično čvrsta.",
                            RecipeId = 1,
                            StepNumber = 19
                        },
                        new
                        {
                            RecipeStepId = 20,
                            Instruction = "Dekoracija šlag krem čokolada.",
                            RecipeId = 1,
                            StepNumber = 20
                        },
                        new
                        {
                            RecipeStepId = 21,
                            Instruction = "Prijatno",
                            RecipeId = 1,
                            StepNumber = 21
                        });
                });

            modelBuilder.Entity("CourseRecipe", b =>
                {
                    b.HasOne("NencyKitchen.DataModel.Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NencyKitchen.DataModel.Entities.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesRecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodCategoryRecipe", b =>
                {
                    b.HasOne("NencyKitchen.DataModel.Entities.FoodCategory", null)
                        .WithMany()
                        .HasForeignKey("FoodCategoriesFoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NencyKitchen.DataModel.Entities.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesRecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.RecipeIngredient", b =>
                {
                    b.HasOne("NencyKitchen.DataModel.Entities.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NencyKitchen.DataModel.Entities.MeasurementUnit", "MeasurementUnit")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("MeasurementUnitId");

                    b.HasOne("NencyKitchen.DataModel.Entities.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("MeasurementUnit");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.RecipeStep", b =>
                {
                    b.HasOne("NencyKitchen.DataModel.Entities.Recipe", "Recipe")
                        .WithMany("RecipeStep")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.MeasurementUnit", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("NencyKitchen.DataModel.Entities.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");

                    b.Navigation("RecipeStep");
                });
#pragma warning restore 612, 618
        }
    }
}
