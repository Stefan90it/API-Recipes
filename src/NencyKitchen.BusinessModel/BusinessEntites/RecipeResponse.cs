using NencyKitchen.DataModel.Entities;

namespace NencyKitchen.BusinessModel.BusinessEntites
{
    public class RecipeResponse
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int Serves { get; set; }
        public bool IsRecipeOfTheDay { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public ICollection<CourseResponse>? Courses { get; set; } =
            new List<CourseResponse>();
        public ICollection<FoodCategoryResponse>? FoodCategories { get; set; } =
            new List<FoodCategoryResponse>();
        public ICollection<RecipeIngredientResponse> RecipeIngredients { get; set; } =
            new List<RecipeIngredientResponse>();
        public ICollection<RecipeStepResponse> RecipeStep { get; set; } =
            new List<RecipeStepResponse>();
    }
}
