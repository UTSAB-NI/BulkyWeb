using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name should be supplied")]
        [DisplayName("Category Name")]
        [MaxLength(30, ErrorMessage = "Category Name should be less than 30 character")]
        public string? Name { get; set; }
        [Range(0, 50, ErrorMessage = "Display Order should be between 0 and 50")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
