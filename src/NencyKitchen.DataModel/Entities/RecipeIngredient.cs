using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NencyKitchen.DataModel.Entities
{
    public class RecipeIngredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeIngredientId { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int? MeasurementUnitId { get; set; }
        public MeasurementUnit MeasurementUnit  { get; set; }
        public double QtyAmount { get; set; }

    }
}
