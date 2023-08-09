using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ILibrary_BuyBooksOnline.Models
{
    public class Category
    {

        [Key]           // Data notation to let know below Id is the primary key
        public int Id { get; set; }
        [Required]      // Indicate that a specific property is required to have a non-null or non-empty value
        [MaxLength(50)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]   //It will separate the Display from Order keyword
        [Range(10, 100, ErrorMessage = "Display Order must be between 10-100")]
        public int DisplayOrder { get; set; }


    }
}
