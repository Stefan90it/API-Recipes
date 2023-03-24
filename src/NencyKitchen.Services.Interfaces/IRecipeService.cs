using NencyKitchen.DataModel.EntitesForCreation;
using NencyKitchen.DataModel.Entities;

namespace NencyKitchen.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> GetRecipesAsync();
        Task<IEnumerable<Recipe>> IsRecipeOfTheDayAsync();
        Task<Recipe?> GetRecipeAsync(int recipeId);
        Recipe CreateRecipe (Recipe recipe);
        Recipe UpdateRecipe (Recipe recipe);
        void DeleteRecipe(int recipeId);
    }
}
