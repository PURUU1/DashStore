using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DashStore.Controllers
{
    public class WishList : Controller
    {
        // GET: WishList
        public ActionResult Index()
        {
            return View();
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
