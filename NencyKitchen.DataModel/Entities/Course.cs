using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NencyKitchen.DataModel.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [Required]
        [MaxLength(50)]
        public string CourseName { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
