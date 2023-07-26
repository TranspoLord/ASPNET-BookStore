using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        [Key] // I know its redundant but I like to be explicit
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(1, 100, ErrorMessage ="Display order must be 1-100")]
        public int DisplayOrder { get; set; }

    }
}
