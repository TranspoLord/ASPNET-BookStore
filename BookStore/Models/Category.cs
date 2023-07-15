using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        [Key] // I know its redundant but I like to be explicit
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string DisplayOrder { get; set; }

    }
}
