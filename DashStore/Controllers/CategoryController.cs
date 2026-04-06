using DashStore.Data;
using DashStore.Models;
using DashStore.Services;
using DashStore.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DashStore.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ProductServices _productServices;
        private readonly ApplicationDbContext _Db;

        public CategoryController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, ProductServices product, ApplicationDbContext Db)
        {
            _logger = logger;
            _userManager = userManager;
            _productServices = product;
            _Db = Db;
        }
        [HttpGet]
        public IActionResult Index(int? id)
        {
            var HomeViewModel = new HomeViewModel();
            if (id != null && id > 0)
            {



                HomeViewModel = new HomeViewModel()
                {
                    Products = _productServices.GetAllProducts().Where(x => x.CategoryId.Equals(id)),
                    Categories = _productServices.GetCategories()
                };
                return View(HomeViewModel);

            }
            else
            {

                 HomeViewModel = new HomeViewModel()
            {
                Categories = _productServices.GetCategories()
            };
            }

            return View(HomeViewModel);
        }

        //public IActionResult Index(int CategoryId)
        //{

        //    return View();
        //}


    }
}
