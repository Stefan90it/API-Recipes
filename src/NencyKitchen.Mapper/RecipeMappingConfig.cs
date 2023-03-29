using Mapster;
using NencyKitchen.BusinessModel;
using NencyKitchen.BusinessModel.BusinessEntites;
using NencyKitchen.BusinessModel.BussinesEntitesForCreation;
using NencyKitchen.DataModel;
using NencyKitchen.DataModel.EntitesForCreation;
using NencyKitchen.DataModel.Entities;
using System;


namespace NencyKitchen.Mapper
{
    public class RecipeMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Ingredient, IngredientResponse>()
                .Map(dest => dest.IngredientName, src => src.IngredientName);
            config.NewConfig<MeasurementUnit, MeasurementUnitResponse>()
                .Map(dest => dest.MeasurementName, src => src.MeasurementName);
            config.NewConfig<RecipeIngredient, RecipeIngredientResponse>()
                .Map(dest => dest.Ingredient.IngredientName, src => src.Ingredient.IngredientName)
                .Map(dest => dest.MeasurementUnit.MeasurementName, src => src.MeasurementUnit.MeasurementName);

            config.NewConfig<Recipe, RecipeResponse>()
                .Map(dest => dest.RecipeIngredients, src => src.RecipeIngredients);


            config.NewConfig<(MeasurementUnit, Ingredient), RecipeIngredient>()
                .Map(dest => dest.MeasurementUnit.MeasurementName, src => src.Item1.MeasurementName)
                .Map(dest => dest.Ingredient.IngredientName, src => src.Item2.IngredientName);

            config.NewConfig<RecipeIngredient, RecipeIngredientResponse>()
                .Map(dest => dest.Ingredient.IngredientName, src => src.Ingredient.IngredientName)
                .Map(dest => dest.MeasurementUnit.MeasurementName, src => src.MeasurementUnit.MeasurementName);

            config.NewConfig<FoodCategory, FoodCategoryResponse>();
            config.NewConfig<FoodCategoryForCreation, FoodCategory>();

            config.NewConfig<Course, CourseResponse>();
            config.NewConfig<CourseForCreation, Course>();

            config.NewConfig<RecipeForCreation, RecipeResponse>()
                .Map(dest => dest.Courses, src => src.Courses)
                .Map(dest => dest.FoodCategories, src => src.FoodCategories)
                .Map(dest => dest.RecipeIngredients, src => src.RecipeIngredients)
                .Map(dest => dest.RecipeStep, src => src.RecipeStep);
            config.NewConfig<RecipeIngredientForCreation, RecipeIngredientResponse>();
            config.NewConfig<RecipeStepForCreation, RecipeStepResponse>();
            config.NewConfig<FoodCategoryForCreation, FoodCategoryResponse>();
            config.NewConfig<CourseForCreation, CourseResponse>();

            config.NewConfig<Recipe, RecipeForCreation>();

        }
    }
}
