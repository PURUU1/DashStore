using DashStore.Data;
using DashStore.Models;
using DashStore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Text.Json;

namespace DashStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager< IdentityUser >_user;
        private CartViewModel cartVm = new CartViewModel();
        public CartViewModel CartViewModel = new CartViewModel();
        public CartController(ApplicationDbContext db, UserManager<IdentityUser> user) { _db = db; _user = user; }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            // Retrieve cart from session
            var cartJson = HttpContext.Session.GetString("SessionCart");
            List<CartItem>? cartItems = string.IsNullOrEmpty(cartJson)
                ? new List<CartItem>()
                : JsonSerializer.Deserialize<List<CartItem>>(cartJson);
            var Total = 0.0;
            foreach (var ItemInCart in cartItems)
            {
                if (ItemInCart.Count > 1)
                {
                    Total += ItemInCart.Price * ItemInCart.Count - 1;

                }
                else
                {
                    Total += ItemInCart.Price;

                }
            }
            decimal baseTotal = (decimal)Total;
            decimal calculatedTotal = Math.Round(baseTotal + 50 + 29, 2, MidpointRounding.AwayFromZero);

            var cart = new CartViewModel()
            {
                CartItems = cartItems,

                // Convert the rounded decimals directly to formatted strings
                SubTotal = double.Parse( Math.Round(baseTotal, 2, MidpointRounding.AwayFromZero).ToString("F2")),

                EstimatedTax = 50.00,
                EstimatedShippingAndHandling = 29.00,

                Total = double.Parse( calculatedTotal.ToString("F2"))
            };

            //var cart = new CartViewModel()
            //{
            //    CartItems = cartItems,
            //    SubTotal = Math.Round(Total),
            //    EstimatedTax = 50,
            //    EstimatedShippingAndHandling = 29,
            //    Total = Math.Round(Total + 50 + 29)

            //};
            
            ///Address is avalible or not
             var currentUser = await _user.GetUserAsync(User);
            User user = new User();
            user.Email = currentUser.Email;
            var address = new  Address();
            var savedAddress = _db.Address.FirstOrDefault(x => x.UserEmail.Equals(user.Email));
            if (savedAddress != null)
            {
               address =  savedAddress;
                cart.adreess = address;
            }
            cartVm = cart;
            TempData["CartData"] = JsonSerializer.Serialize<CartViewModel>(cart);

            return View(cart);
        }

    
        public IActionResult Checkout()
        {

           

            //Console.WriteLine(CartViewModel);
            return RedirectToAction("Index", "Address");
        }

        //[HttpPost]
        public IActionResult AddToCart(int Id)
        {
            var ProductId = Id;
            int quatity = int.Parse(Request.Form["quatity"]);
            int Update = 0;
            if (Request.Form.ContainsKey("Update"))
            {
            Update = int.Parse(Request.Form["Update"]);

            }
            
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

            if (Update.Equals(1))
            {
                if (quatity != 0)
                {
                    existingItem.Count = quatity;

                }
            }
            else if (existingItem != null)
            {

                if (quatity != 0)
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
                    Count = quatity,
                    ImageUrl = product.ImageUrl // Get first image from your comma list
                });
                success = true;
            }



            // Save back to session
            HttpContext.Session.SetString("SessionCart", JsonSerializer.Serialize(cart));

            return Json(new { success });
        }
        [HttpPost]
        public IActionResult RemoveFromCart(int Id)
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

            if (cart.Count.Equals(0))
            {
                return Json(new { success, RemoveFromCartUi, count = cart.Count });
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


            

            return Json(new { success, RemoveFromCartUi, count = existingItem.Count });
        }


        [HttpPost]
        public IActionResult RemoveFromCartTotally(int Id)
        {
            var ProductId = Id;

            var success = false;
            var RemoveFromCartUi = false;

            var cartJson = HttpContext.Session.GetString("SessionCart");

            List<CartItem> cart;




            cart = JsonSerializer.Deserialize<List<CartItem>>(cartJson);

            var CartProduct = cart.FirstOrDefault(x => x.ProductId.Equals(ProductId));
            if (CartProduct != null)
            {
                cart.Remove(CartProduct);
                success = true;
                RemoveFromCartUi = true;
            }
            HttpContext.Session.SetString("SessionCart", JsonSerializer.Serialize(cart));
            return Json(new { success, RemoveFromCartUi });
        }
    }
}
