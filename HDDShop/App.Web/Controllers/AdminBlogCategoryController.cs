using App.DataAccess.Services.Blogs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    
    public class AdminBlogCategoryController : Controller
    {
        IBlogCategoryService _blogCategoryService;
        public AdminBlogCategoryController(IBlogCategoryService blogCategoryService)
        {
            _blogCategoryService = blogCategoryService;
        }
        // GET: AdminBlogCategoryController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminBlogCategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminBlogCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminBlogCategoryController/Create
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

        // GET: AdminBlogCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminBlogCategoryController/Edit/5
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

        // GET: AdminBlogCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminBlogCategoryController/Delete/5
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
