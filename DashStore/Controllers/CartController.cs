using DashStore.Data;
using DashStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Text.Json;

namespace DashStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CartController(ApplicationDbContext db) { _db = db; }
        public IActionResult Index()
        {
            // Retrieve cart from session
            var cartJson = HttpContext.Session.GetString("SessionCart");
            List<CartItem> cart = string.IsNullOrEmpty(cartJson)
                ? new List<CartItem>()
                : JsonSerializer.Deserialize<List<CartItem>>(cartJson);



            return View(cart);
        }


        [HttpPost]
        public IActionResult AddToCart(int Id )
        {
            var ProductId = Id;
            int quatity = int.Parse(Request.Form["quatity"]);
            var success = false;
            var product = _db.Products.FirstOrDefault(x => x.Id.Equals(ProductId));
            if (product == null)
            {
                success = false;
                return NotFound();
            }

            var cartJson = HttpContext.Session.GetString("SessionCart");

            List<CartItem> cart;

            if (string.IsNullOrEmpty(cartJson))
            {
                // If session is empty, create a brand new list
                cart = new List<CartItem>();
            }
            else
            {
                // If session has data, "melt" the JSON string back into a List
                cart = JsonSerializer.Deserialize<List<CartItem>>(cartJson);
            }
            var existingItem = cart.FirstOrDefault(u => u.ProductId == ProductId);

            if (existingItem != null)
            {
                
            if(quatity!= 0 )
            {
                existingItem.Count += quatity;

            }

            }
            else
            {
                cart.Add(new CartItem
                {
                    ProductId = ProductId,
                    ProductName = product.Title,
                    Price = product.Price,
                    Count = quatity ,
                    ImageUrl = product.ImageUrl.Split(',')[0] // Get first image from your comma list
                });
                success = true;
            }

           

            // Save back to session
            HttpContext.Session.SetString("SessionCart", JsonSerializer.Serialize(cart));

            return Json(new { success });
        }
        [HttpPost]
        public IActionResult RemoveFromCart(int Id )
        {
            var ProductId = Id;

            var success = false;
            var RemoveFromCartUi = false;

            var cartJson = HttpContext.Session.GetString("SessionCart");

            List<CartItem> cart;

            if (string.IsNullOrEmpty(cartJson))
            {
                // If session is empty, create a brand new list
                cart = new List<CartItem>();
                return NotFound();
            }
            else
            {
                // If session has data, "melt" the JSON string back into a List
                cart = JsonSerializer.Deserialize<List<CartItem>>(cartJson);
            }
            var existingItem = cart.FirstOrDefault(u => u.ProductId == ProductId);
                var CartProduct = cart.FirstOrDefault(x => x.ProductId.Equals(ProductId));
            if (existingItem != null)
            {
                existingItem.Count--;

            }

            if (CartProduct.Equals(null))
            {
                return Json(new { success, RemoveFromCartUi, count = existingItem.Count });
            }
            if (CartProduct.Count <= 0)
            {
                cart.Remove(CartProduct);
                success = true;
                RemoveFromCartUi = true;

       }

            // Save back to session
            HttpContext.Session.SetString("SessionCart", JsonSerializer.Serialize(cart));

           


            return Json(new { success , RemoveFromCartUi , count = existingItem.Count });
        }
        }
}
