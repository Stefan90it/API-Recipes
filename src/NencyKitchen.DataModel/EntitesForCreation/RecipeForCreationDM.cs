using NencyKitchen.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.DataModel.EntitesForCreation
{
    public class RecipeForCreationDM
    {
        public string RecipeName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int Serves { get; set; }
        public bool IsRecipeOfTheDay { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public ICollection<CourseForCreationDM>? Courses { get; set; } =
            new List<CourseForCreationDM>();
        public ICollection<FoodCategoryForCreationDM>? FoodCategories { get; set; } =
            new List<FoodCategoryForCreationDM>();
        public ICollection<RecipeIngredientForCreationDM> RecipeIngredients { get; set; } =
            new List<RecipeIngredientForCreationDM>();
        public ICollection<RecipeStepForCreationDM> RecipeStep { get; set; } =
            new List<RecipeStepForCreationDM>();
    }
}
