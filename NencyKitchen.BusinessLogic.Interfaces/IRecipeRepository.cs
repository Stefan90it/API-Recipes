using NencyKitchen.BusinessModel.BusinessEntites;
using NencyKitchen.BusinessModel.BussinesEntitesForCreation;
using NencyKitchen.DataModel.EntitesForCreation;
using NencyKitchen.DataModel.Entities;

namespace NencyKitchen.BusinessLogic.Interfaces
{
    public interface IRecipeRepository
    {
        Task<IEnumerable<Recipe>> GetRecipesResponseAsync();
        Task<IEnumerable<Recipe>> IsRecipeOfTheDayResponseAsync();
        Task<RecipeResponse> GetRecipeResponseAsync(int recipeId);
        Recipe CreateRecipeResponse(Recipe recipe);
        Recipe UpdateRecipeResponse(Recipe recipe); 
        void DeleteRecipeResponse(int recipeId);
    }
}
