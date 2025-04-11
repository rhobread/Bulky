using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        [Required]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

    }
}
