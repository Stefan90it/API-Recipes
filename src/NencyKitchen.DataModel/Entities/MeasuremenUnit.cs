using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NencyKitchen.DataModel.Entities
{
    public class MeasurementUnit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? MeasurementUnitId { get; set; }
        public string? MeasurementName { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
