using DashStore.Models;
using Microsoft.Build.Framework;

namespace DashStore.ViewModels
{
    public class CheckoutViewModel
    {
        [Required]
        public User user { get; set; }  
        [Required]
        public CartViewModel Cart { get; set; } 

    }
}
