using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NencyKitchen.DataModel.Entities
{
    public class RecipeStep
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeStepId { get; set; }
        public int StepNumber { get; set; }
        [MaxLength(200)]
        public string Instruction { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
