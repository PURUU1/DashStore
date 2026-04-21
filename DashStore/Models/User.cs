
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    namespace DashStore.Models
    {
        // Inherits from IdentityUser to get built-in auth properties
        public class User : IdentityUser
        {
            [Required]
            public string? Name { get; set; }

            [Required]
            public Address? Address { get; set; }    
        }
    }


