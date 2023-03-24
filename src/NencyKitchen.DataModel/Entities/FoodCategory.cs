using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NencyKitchen.DataModel.Entities
{
    public class FoodCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodCategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
