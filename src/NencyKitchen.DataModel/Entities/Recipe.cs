using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NencyKitchen.DataModel.Entities
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeId { get; set; } = default!;
        [Required]
        [MaxLength(50)]
        public string RecipeName { get; set; } = default!;
        [Required]
        [MaxLength(200)]
        public string ShortDescription { get; set; } = default!;
        [MaxLength(500)]
        public string? LongDescription { get; set; } = default!;
        public int Serves { get; set; } = default!;
        public bool IsRecipeOfTheDay { get; set; }
        public string ImageUrl { get; set; } = default!;
        public string ImageThumbnailUrl { get; set; } = default!;
        public ICollection<Course>? Courses { get; set; } = 
            new List<Course>();
        public ICollection<FoodCategory>? FoodCategories { get; set; } = 
            new List<FoodCategory>();
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = 
            new List<RecipeIngredient>();
        public ICollection<RecipeStep> RecipeStep { get; set; } = 
            new List<RecipeStep>();
    }
}
