using NencyKitchen.BusinessLogic.Interfaces;
using NencyKitchen.BusinessModel.BusinessEntites;
using NencyKitchen.DataModel.Entities;
using NencyKitchen.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.BusinessLogic
{
    public class RecipeIngredientRepository : IRecipeIngredientRepository
    {
        private readonly IRecipeIngredientService _recipeIngredientService;

        public RecipeIngredientRepository(IRecipeIngredientService recipeIngredientService)
        {
            _recipeIngredientService = recipeIngredientService;
        }
        public async Task<IEnumerable<RecipeIngredient>> GetAllIngredientsResponseAsync(int recipeId)
        {
            return await _recipeIngredientService.GetAllIngredientsAsync(recipeId);
        }
    }
}
