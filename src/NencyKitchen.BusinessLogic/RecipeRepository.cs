using MapsterMapper;
using NencyKitchen.BusinessLogic.Interfaces;
using NencyKitchen.BusinessModel.BusinessEntites;
using NencyKitchen.BusinessModel.BussinesEntitesForCreation;
using NencyKitchen.DataModel.EntitesForCreation;
using NencyKitchen.DataModel.Entities;
using NencyKitchen.Services.Interfaces;

namespace NencyKitchen.BusinessLogic
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IRecipeService _recipeService;
        private readonly IMapper _mapper;

        public RecipeRepository(IRecipeService recipeService, IMapper mapper)
        {
            _recipeService = recipeService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Recipe>> GetRecipesResponseAsync()
        {
            return await _recipeService.GetRecipesAsync();
        }

        public Recipe CreateRecipeResponse(Recipe recipe)
        {
            return _recipeService.CreateRecipe(recipe);
        }

        public void DeleteRecipeResponse(int recipeId)
        { 
            _recipeService.DeleteRecipe(recipeId);
        }

        public async Task<RecipeResponse> GetRecipeResponseAsync(int recipeId)
        {
            var tst = await _recipeService.GetRecipeAsync(recipeId);
            var result = _mapper.Map<RecipeResponse>(tst);
            return result;
        }

        public Recipe UpdateRecipeResponse(Recipe recipe)
        {
            return _recipeService.UpdateRecipe(recipe);
        }

        public async Task<IEnumerable<Recipe>> IsRecipeOfTheDayResponseAsync()
        {
            return await _recipeService.IsRecipeOfTheDayAsync();
        }
    }
}
