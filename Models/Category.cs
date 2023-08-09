using System.ComponentModel.DataAnnotations;

namespace ILibrary_BuyBooksOnline.Models
{
    public class Category
    {
        [Key]  // Data notation to let know below Id is the primary key
        public int Id { get; set; }
        [Required] // Indicate that a specific property is required to have a non-null or non-empty value
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
