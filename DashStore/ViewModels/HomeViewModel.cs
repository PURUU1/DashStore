using DashStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace DashStore.ViewModels
{
    public class HomeViewModel
    {
        [Required]
        public IdentityUser User { get; set; }

        public IEnumerable<Product>? Products { get; set; }
        public IEnumerable<Category>? Categories { get; set; }


    }
}
