
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    namespace DashStore.Models
    {
        // Inherits from IdentityUser to get built-in auth properties
        public class User : IdentityUser
        {
            [Required]
            public string? Name { get; set; }

            public string? StreetAddress { get; set; }
            public string? City { get; set; }
            public string? State { get; set; }
            public string? PostalCode { get; set; }
        }
    }


