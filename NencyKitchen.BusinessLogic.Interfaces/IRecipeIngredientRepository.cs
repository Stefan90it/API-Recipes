using NencyKitchen.BusinessModel.BusinessEntites;
using NencyKitchen.DataModel.Entities;

namespace NencyKitchen.BusinessLogic.Interfaces
{
    public interface IRecipeIngredientRepository
    {
        Task<IEnumerable<RecipeIngredient>> GetAllIngredientsResponseAsync(int recipeId);
    }
}
