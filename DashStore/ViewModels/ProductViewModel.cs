using DashStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace DashStore.ViewModels
{
    public class ProductViewModel
    {
   

     
        [Required]
        public Product product { get; set; }
        public List<Product>? SuggestedProducts { get; set; }


    }
}
