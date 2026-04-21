using System.ComponentModel.DataAnnotations;

namespace DashStore.Models
{
    public class Address
    {
        
        public String? UserEmail { get; set; }
        [Key]
        public int AddressId { get; set; }

        
        [Required]
        [Display(Name = "Address Title")]
        public string Title { get; set; } // e.g., "2118 Thornridge" or "Headoffice"

        

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        
    }
}
