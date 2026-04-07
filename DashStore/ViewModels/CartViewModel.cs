using DashStore.Models;

namespace DashStore.ViewModels
{
    public class CartViewModel
    {
        public List<CartItem>? CartItems { get; set; }
        public double? SubTotal { get; set; }
        public double? EstimatedTax { get; set; }
        public double? EstimatedShippingAndHandling { get; set; }
        public double? Total { get; set; }
    }
}
