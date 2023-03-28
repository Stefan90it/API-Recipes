using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using NencyKitchen.BusinessLogic.Interfaces;
using NencyKitchen.BusinessModel.BusinessEntites;
using NencyKitchen.BusinessModel.BussinesEntitesForCreation;
using NencyKitchen.DataModel.EntitesForCreation;
using NencyKitchen.DataModel.Entities;

namespace NensyKicthen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IMapper _mapper;
        private readonly LinkGenerator _linkGenerator;

        public RecipesController(IRecipeRepository recipeRepository, IMapper mapper, LinkGenerator linkGenerator)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
            _linkGenerator = linkGenerator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeResponse>>> GetRecipes()
        {
            try
            {
                var results = await _recipeRepository.GetRecipesResponseAsync();
                List<RecipeResponse> recipes = _mapper.Map<List<RecipeResponse>>(results);
                return recipes;
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Unkonwn error");
            }
        }

        [HttpGet("{recipeId}")]
        public async Task<ActionResult<RecipeResponse>> GetRecipe(int recipeId)
        {
            try
            {
                var recipeEntity = await _recipeRepository.GetRecipeResponseAsync(recipeId);
                if (recipeEntity == null)
                {
                    return NotFound();
                }
                return recipeEntity;

            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Unkonwn error");
            }
        }

        [HttpPost]

        public ActionResult<RecipeForCreation> Post(RecipeForCreation recipe)
        {
            try
            {
                var recipeEntity = _mapper.Map<Recipe>(recipe);
                var newRecipe = _recipeRepository.CreateRecipeResponse(recipeEntity);
                var result = _mapper.Map<RecipeForCreation>(newRecipe);

                var location = _linkGenerator.GetPathByAction("Get", "Recipes", new { recipeId = result.RecipeId });
                return Created(location, result);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Unknown error");
            }
        }

        [HttpPut("{recipeId}")]
        public ActionResult<RecipeResponse> Put(int recipeId, RecipeResponse recipe)
        {
            try
            {
                recipe.RecipeId = recipeId;
                var recipeDM = _mapper.Map<Recipe>(recipe);
                var updatedRecipe = _recipeRepository.UpdateRecipeResponse(recipeDM);
                return Ok(_mapper.Map<RecipeResponse>(updatedRecipe));
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Unknown error");
            }
        }

        [HttpDelete("{recipeId}")]
        public IActionResult Delete(int recipeId)
        {
            try
            {
                var recipe = _recipeRepository.GetRecipeResponseAsync(recipeId);
                if (recipe == null)
                {
                    return NotFound();
                }
                _recipeRepository.DeleteRecipeResponse(recipeId);
                return Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Unknown error");
            }
        }
    }
}
