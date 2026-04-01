using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DashStore.Models
{

    
        public class Category
        {
            [Key] // Marks this as the Primary Key
            public int Id { get; set; }

            [Required] // Cannot be null in the database
            [MaxLength(50)]
            [DisplayName("Category Name")]
            public string Name { get; set; }

            [DisplayName("Display Order")]
            [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100")]
            public int DisplayOrder { get; set; }

            public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        }
    

}
