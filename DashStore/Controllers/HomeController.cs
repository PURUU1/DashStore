using DashStore.Data;
using DashStore.Models;
using DashStore.Services;
using DashStore.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Diagnostics;

namespace DashStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ProductServices _productServices;
        private readonly ApplicationDbContext _Db;

        public HomeController(ILogger<HomeController> logger , UserManager<IdentityUser> userManager  , ProductServices product ,ApplicationDbContext Db )
        {
            _logger = logger;
            _userManager = userManager;
            _productServices = product;
            _Db = Db;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["ShowSubNav"] = true;
            var currentUser = await _userManager.GetUserAsync(User);


            //var products = _productServices.GetAllProducts();
            var products = _productServices.GetAllProducts();
            //HttpContext.Session.Remove("SessionCart");

            var categoryList = _productServices.GetCategories().ToList();
            if (currentUser != null)
            {
                //ViewBag.Name = currentUser.Email;
            }
            var HomeViewModel = new HomeViewModel()
            {
                User = currentUser,
                Products = products,
                Categories = categoryList ,
                ProductsInCategory = _productServices.GetProductsInCategory().Cast<CategoryList>()
            };

            
            return View(HomeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
