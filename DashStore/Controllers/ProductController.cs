using DashStore.Data;
using DashStore.Models;
using DashStore.Services;
using DashStore.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DashStore.Controllers
{
    public class ProductController : Controller
    {
        
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ProductServices _productServices;
        private readonly ApplicationDbContext _Db;

        public ProductController( UserManager<IdentityUser> userManager, ProductServices product, ApplicationDbContext Db)
        {
            
            _userManager = userManager;
            _productServices = product;
            _Db = Db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Categories()
        {
            return View();
        }




        public IActionResult Buy(int id)
        {


            return Json(new { });
        }
        public IActionResult Details(int id)
        {
            if(id is not 0)
            {
                var product = _productServices.GetProduct(id);
                var Suuggetions = _productServices.GetSuggetions(product.CategoryId);
            var ProductViewModel = new ProductViewModel()
            {
                product = product,
                SuggestedProducts = Suuggetions,
            };
                return View( ProductViewModel);

            }

         
                return NotFound(); 
         


        }
    }
}
