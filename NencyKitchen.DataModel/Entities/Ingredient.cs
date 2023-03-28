using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NencyKitchen.DataModel.Entities
{
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IngredientId { get; set; }
        [Required]
        [MaxLength(50)]
        public string IngredientName { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
