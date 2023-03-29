using NencyKitchen.BusinessModel.BusinessEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.BusinessModel.BussinesEntitesForCreation
{
    public class RecipeForCreation
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int Serves { get; set; }
        public bool IsRecipeOfTheDay { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public ICollection<CourseForCreation>? Courses { get; set; } =
            new List<CourseForCreation>();
        public ICollection<FoodCategoryForCreation>? FoodCategories { get; set; } =
            new List<FoodCategoryForCreation>();
        public ICollection<RecipeIngredientForCreation> RecipeIngredients { get; set; } =
            new List<RecipeIngredientForCreation>();
        public ICollection<RecipeStepForCreation> RecipeStep { get; set; } =
            new List<RecipeStepForCreation>();
    }
}
