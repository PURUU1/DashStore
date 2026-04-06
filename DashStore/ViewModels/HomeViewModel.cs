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

        public IEnumerable<CategoryList>? ProductsInCategory { get; set; }


    }

    public class CategoryList
    {
        [Required]
        public string Name { get; set; }
        // Key = Category Name (string)
// Value = List of Products belonging to that category
public  IEnumerable<Product>? ProductsByCategory { get; set; } 
    }
}
