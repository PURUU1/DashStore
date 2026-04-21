using DashStore.Models;
using DashStore.Services;
using DashStore.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DashStore.Controllers
{
    public class PaymentController : Controller
    {
        private readonly EmailServices _EmailService;
        private readonly UserManager<IdentityUser> _userManager ;
        public PaymentController(EmailServices emailService , UserManager<IdentityUser> userManager) { _EmailService = emailService; _userManager = userManager; }
        [HttpGet]
        public IActionResult Index()
        {
            if (TempData["CartData"] is string jsonData)
            {
                var model = JsonConvert.DeserializeObject<CartViewModel>(jsonData);
                
                TempData.Keep("CartData");
                return View(model);
            }

            var CartVm = new CartViewModel();
            return View(CartVm);
        }
        [HttpPost]
        public IActionResult Index(CartViewModel model)
        {
            //foreach (var key in ModelState.Keys.ToList())
            //{
            //    // If the key DOES NOT start with "Card", remove its validation errors
            //    if (!key.StartsWith("Card"))
            //    {
            //        ModelState.Remove(key);
            //    }
            //}
            var cardValid = ModelState.GetFieldValidationState("Card") == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Valid;

            if (!cardValid)
            {
                
                return View(model);
            }

            // Process successful payment here...
            return RedirectToAction("ProcessPayment" , model);
        }
        
        public async Task<IActionResult> ProcessPayment(CartViewModel model)
        {
          

            
            
            var currentUser = await _userManager.GetUserAsync(User);
            User user = new User();
            user.Email = currentUser.Email;
            string emailBody = $@"

        ";

            // 3. Send the Email
            if (TempData["CartData"] is string jsonData)
            {
                CartViewModel? cartViewModel = JsonConvert.DeserializeObject<CartViewModel>(jsonData);
                TempData.Keep("CartData");
                var BuyiedItems = cartViewModel.CartItems;

                var ProductCard = $@"";
                foreach(var product in BuyiedItems)
                {
                    ProductCard += $@"
   <div class=""product-item"">
                            
                            <p class=""product-name"">{product.ProductName}</p>
                            <span class=""product-price"">${product.Price}</span>
                        </div>
";
                }

                 emailBody = $@"

        <html>
            <body style='font-family: sans-serif;'>
                <h1 style='color: #000;'>Order Confirmed!</h1>
                <p>Hi {user.Email}, your order has been placed successfully.</p>
                <div style='border: 1px solid #ddd; padding: 15px; border-radius: 10px;'>
                    <h3>Order Summary</h3>
                    <p><strong>Order Total:</strong> {model.Total:C}</p>
                    <p><strong>Shipping to:</strong> {cartViewModel.adreess.StreetAddress}, {cartViewModel.adreess.City}</p>
                    <p><strong>Products:</strong>    {ProductCard}</p>

                    
                </div>
                <p>Thank you for shopping with <strong>DashStore</strong>!</p>
            </body>
        </html>";


            await _EmailService.SendEmailAsync(user.Email, "Your DashStore Order Slip", emailBody);
                return View("Success",cartViewModel);
            }


            var CartVm = new CartViewModel();
            return View("Fail",CartVm);
        }
        public IActionResult Success(CartViewModel cartvm)
        {
            return View(cartvm);
        }
        public IActionResult Fail(CartViewModel cartvm)
        {
            return View(cartvm);
        }
        }
}
