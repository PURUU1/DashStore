using DashStore.Data;
using DashStore.Migrations;
using DashStore.Models;
using DashStore.Services;
using DashStore.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DashStore.Controllers
{
    public class AddressController : Controller
    {
        
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ProductServices _productServices;
        private readonly ApplicationDbContext _Db;

        public AddressController( UserManager<IdentityUser> userManager, ProductServices product, ApplicationDbContext Db)
        {
            
            _userManager = userManager;
            _productServices = product;
            _Db = Db;
        }

        public async Task<IActionResult> Remove(int Id)
        {

            var add = _Db.Address.FirstOrDefault(x => x.AddressId.Equals(Id));
            _Db.Address.Remove(add);
            _Db.SaveChanges();
            return Json(new { succ = true });
        }


        [HttpPost]
        public async Task<IActionResult> AddAddress([FromBody] Address Adress)
        {

            var currentUser = await _userManager.GetUserAsync(User);



                var Add = _Db.Address.FirstOrDefault(x => x.UserEmail.Equals(currentUser.Email));
            if (Add != null)
            {
                Add.City = Adress.City;
                Add.PhoneNumber = Adress.PhoneNumber;
                Add.StreetAddress = Adress.StreetAddress;
                Add.PostalCode = Adress.PostalCode;
                Add.Title = Adress.Title;
                Add.State = Adress.State;
                _Db.Address.Update(Add);
                _Db.SaveChanges();
                return Json(new { succ = true , Add});
            }
            else
            {
                var newAdd = new Address()
                {
                    Title = Adress.Title,
                    City = Adress.City,
                    State = Adress.State,
                    StreetAddress = Adress.StreetAddress,
                    PostalCode = Adress.PostalCode,
                    PhoneNumber = Adress.PhoneNumber,
                    UserEmail = currentUser.Email,


                };
                _Db.Address.Add(newAdd);
                _Db.SaveChanges();
                return Json(new { succ = true, newAdd });

            }

                return Json(new { succ = false });
        }


        public async Task<IActionResult> Index()
        {
            
            var currentUser = await _userManager.GetUserAsync(User);
            User user = new User();
            user.Email = currentUser.Email;
            //user.Address = new Address();
            if (TempData["CartData"] is string jsonData)
            {

                var savedAddress = _Db.Address.FirstOrDefault(x => x.UserEmail.Equals(user.Email));
                if (savedAddress != null)
                {
                    user.Address = savedAddress;
                }
                else
                {
                    // Handle the case for a new user
                    user.Address = new Address(); // Create a blank one to avoid crashes in the View
                }
                //var jsonData = TempData["CartData"] as string;

                // This tells TempData: "Don't delete 'CartData' yet, I might need it again."
                TempData.Keep("CartData");
                //var cartVM = JsonConvert.DeserializeObject<CartViewModel>(jsonData);

                // Convert it back into an object
                var cartVM = JsonConvert.DeserializeObject<CartViewModel>(jsonData);
                var checkOutViewModell = new CheckoutViewModel()
                {
                    user = user,

                    Cart = cartVM

                };
                return View(checkOutViewModell);
            }
            

            
            
            //varCartItems.Add();
            var checkOutViewModel = new CheckoutViewModel()
            {
                user = user,

                Cart = new CartViewModel()

            };
            return View(checkOutViewModel);
        }
    }
}
