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
        [HttpGet]
        public IActionResult Search([FromQuery]ProductSearchQuery query)
        {

            if( !string.IsNullOrEmpty(query.text))
            {
            Console.WriteLine(query);
            var Products = _productServices.GetAllProducts();
            var searchResult = Products.Where(x => x.Title.Contains(query.text,StringComparison.OrdinalIgnoreCase)).ToList();
            return Json(new {succ="true", searchResult });

            }
            return Json(new { succ = "false" });
        }

        public IActionResult Details(int id)
        {
            if(id is not 0)
            {
                var product = _productServices.GetProduct(id);
                var Suuggetions = _productServices.GetSuggetionsForProduct(product.CategoryId);
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
