using AspNetCoreGeneratedDocument;
using DashStore.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DashStore.Controllers
{
    
        [Authorize] // Must be logged in to use the wishlist
        public class WishlistController : Controller
        {
            private readonly ApplicationDbContext _context;
            private readonly UserManager<IdentityUser> _userManager;
            

            public WishlistController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
            {
                _context = context;
                _userManager = userManager;
             
            }

            [HttpPost]
            public async Task<IActionResult> ToggleWishlist(int productId)
            {
                // 1. Get the current logged-in user's ID
                var userId = _userManager.GetUserId(User);

                // 2. Check if this exact product is already in this user's wishlist
                var existingItem = _context.WishlistItems
                    .FirstOrDefault(w => w.ProductId == productId && w.UserId == userId);

                if (existingItem != null)
                {
                    // It exists! So we remove it (Un-heart)
                    _context.WishlistItems.Remove(existingItem);
                    await _context.SaveChangesAsync();
                    return Json(new { success = true, isAdded = false, message = "Removed from wishlist" });
                }
                else
                {
                // It doesn't exist! So we add it (Heart)
                var productt = _context.Products.FirstOrDefault(x => x.Id.Equals(productId));
                    var newItem = new WishlistItem { ProductId = productId, UserId = userId , Product = productt   };
                    _context.WishlistItems.Add(newItem);
                     _context.SaveChanges();
                    return Json(new { success = true, isAdded = true, message = "Added to wishlist" });
                }
            }
        
        // GET: WishList
        public async Task<IActionResult> Index()
        {
            // 1. Get the current logged-in user
            var userId = _userManager.GetUserId(User);

            // 2. Fetch their wishlist from the database AND include the actual Product data
            var userWishlist = await _context.WishlistItems
                .Include(w => w.Product) // This is crucial! It joins the Product table.
                .Where(w => w.UserId == userId)
                .ToListAsync();
            // 2. Fetch their wishlist from the database AND include the actual Product data
            //var userWishlist =  _context.WishlistItems.Where(w => w.UserId == userId).ToList();   


            // 3. Send the list to the View
            return View(userWishlist);
        }

        // GET: WishList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WishList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WishList/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WishList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WishList/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WishList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WishList/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
