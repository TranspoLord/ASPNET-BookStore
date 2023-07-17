using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        [Key] // I know its redundant but I like to be explicit
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }

    }
}
