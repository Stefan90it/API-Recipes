using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using NencyKitchen.BusinessLogic.Interfaces;
using NencyKitchen.BusinessModel.BusinessEntites;
using NencyKitchen.BusinessModel.BussinesEntitesForCreation;
using NencyKitchen.DataModel.Entities;
using NencyKitchen.Services;

namespace NensyKicthen.Controllers
{
    [Route("api/recipes/{recipeId}/[controller]")]
    [ApiController]
    public class RecipeIngredientsController : ControllerBase
    {
        private readonly IRecipeIngredientRepository _recipeIngredientRepository;
        private readonly IMapper _mapper;

        public RecipeIngredientsController(IRecipeIngredientRepository recipeIngredientRepository, IMapper mapper)
        { 
            _recipeIngredientRepository = recipeIngredientRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeIngredientResponse>>> GetRecipeingredients(int recipeId)
        {
            try
            {

                IEnumerable<RecipeIngredientResponse> result = new List<RecipeIngredientResponse>();
                var ingredietns = await _recipeIngredientRepository.GetAllIngredientsResponseAsync(recipeId);
                result = _mapper.Map<IEnumerable<RecipeIngredientResponse>>(ingredietns);
                return Ok(result);
                
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Unkonwn error");
            }
        }
    }
}
