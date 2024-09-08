using App.DataAccess.Dtos.Abouts;
using App.DataAccess.Services.Abouts;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class AdminAboutUsController : Controller
    {
        IAboutService _aboutService;
        public AdminAboutUsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        // GET: AdminAboutUsController
        public async Task<IActionResult> Index()
        {
            var Data = await _aboutService.GetAll();
            return View(Data);
        }

        // GET: AdminAboutUsController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var Data =await _aboutService.GetById(id);
            return View(Data);
        }

        // GET: AdminAboutUsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminAboutUsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddOrUpdateAboutDto model)
        {
            try
            {
                await _aboutService.Add(model);
                return RedirectToAction(nameof(Index),"AdminAboutUs");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminAboutUsController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var Data =await _aboutService.GetById(id);
            return View(new AddOrUpdateAboutDto()
            {
                Description = Data.Description,
                Image=Data.Image,
                Title=Data.Title,
            }) ;
        }

        // POST: AdminAboutUsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AddOrUpdateAboutDto model)
        {
            try
            {

                await _aboutService.Update(id, model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminAboutUsController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var Data =await _aboutService.GetById(id.Value);

            return View(Data);
        }

        // POST: AdminAboutUsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _aboutService.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
