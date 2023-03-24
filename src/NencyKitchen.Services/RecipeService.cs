using Microsoft.EntityFrameworkCore;
using NencyKitchen.DataModel.Entities;
using NencyKitchen.Services.DbContexts;
using NencyKitchen.Services.Interfaces;

namespace NencyKitchen.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly NencyKitchenDbContext _nencyKitchenDbContext;
        public RecipeService(NencyKitchenDbContext nencyKitchenDbContext)
        {
            _nencyKitchenDbContext = nencyKitchenDbContext;
        }

        public async Task<IEnumerable<Recipe>> GetRecipesAsync()
        {
            var tst2 = _nencyKitchenDbContext.RecipeIngredients.
                Include(a => a.MeasurementUnit)
                .Include(b => b.Ingredient)
                .ToList();
            return await _nencyKitchenDbContext.Recipes.
                Include(c => c.Courses).
                Include(f => f.FoodCategories).
                Include(r => r.RecipeIngredients).
                Include(s => s.RecipeStep).
                OrderBy(n => n.RecipeName).
                ToListAsync();
        }

        public async Task<Recipe?> GetRecipeAsync(int recipeId)
        {
            var tst2 = _nencyKitchenDbContext.RecipeIngredients.
                Include(a => a.MeasurementUnit)
                .Include(b => b.Ingredient)
                .ToList();
            return await _nencyKitchenDbContext.Recipes.
                    Include(c => c.Courses).
                    Include(f => f.FoodCategories).
                    Include(r => r.RecipeIngredients).
                    Include(s => s.RecipeStep).
                    Where(r => r.RecipeId == recipeId).
                    FirstOrDefaultAsync();
        }

        public Recipe CreateRecipe(Recipe recipe)
        {
            _nencyKitchenDbContext.Recipes.Add(recipe);
            _nencyKitchenDbContext.SaveChanges();
            return recipe;
        }

        public Recipe UpdateRecipe(Recipe recipe)
        {
            var updatatedRecipe = _nencyKitchenDbContext.Recipes.
                    Include(c => c.Courses).
                    Include(f => f.FoodCategories).
                    Include(r => r.RecipeIngredients).
                    Include(s => s.RecipeStep).
                    FirstOrDefault(r => r.RecipeId == recipe.RecipeId);
            if (updatatedRecipe != null)
            {
                updatatedRecipe.RecipeName = recipe.RecipeName;
                updatatedRecipe.FoodCategories = recipe.FoodCategories;
                updatatedRecipe.Courses = recipe.Courses;
                updatatedRecipe.Serves = recipe.Serves;
                updatatedRecipe.ShortDescription = recipe.ShortDescription;
                updatatedRecipe.LongDescription = recipe.LongDescription;
                updatatedRecipe.RecipeIngredients = recipe.RecipeIngredients;
                updatatedRecipe.RecipeStep = recipe.RecipeStep;
                updatatedRecipe.ImageUrl = recipe.ImageUrl;
                updatatedRecipe.ImageThumbnailUrl = recipe.ImageThumbnailUrl;
                _nencyKitchenDbContext.SaveChanges();
            }
            return updatatedRecipe;
        }

        public void DeleteRecipe(int recipeId)
        {
            var recipe = _nencyKitchenDbContext.Recipes.
                    Include(c => c.Courses).
                    Include(f => f.FoodCategories).
                    Include(r => r.RecipeIngredients).
                    Include(s => s.RecipeStep).
                    FirstOrDefault(r => r.RecipeId == recipeId);
            if (recipe != null)
            {
                _nencyKitchenDbContext.Recipes.Remove(recipe);
                _nencyKitchenDbContext.SaveChanges();
            }
        }

        public async Task<IEnumerable<Recipe>> IsRecipeOfTheDayAsync()
        {
            return await _nencyKitchenDbContext.Recipes.
                Include(c => c.Courses).
                Include(f => f.FoodCategories).
                Include(r => r.RecipeIngredients).
                Include(s => s.RecipeStep).
                OrderBy(n => n.RecipeName).
                Where(i => i.IsRecipeOfTheDay).
                ToListAsync();
        }
    }
}
