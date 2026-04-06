using System.ComponentModel.DataAnnotations;

namespace DashStore.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }

        // This stores ONLY the first image from your comma-separated string
        public string ImageUrl { get; set; }

        // Optional: A helper property to calculate subtotal for this item
        public double TotalPrice => Price * Count;
    }
}