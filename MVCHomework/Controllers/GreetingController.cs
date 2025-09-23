using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCHomework.Models;
using System.Security.Principal;

namespace MVCHomework.Controllers
{
    public class GreetingController : Controller
    {
        // GET: GreetingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GreetingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GreetingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GreetingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GreetingModel model)
        {
            try
            {
                ViewBag.Message = $"Hi {model.FirstName} {model.LastName}";

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: GreetingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GreetingController/Edit/5
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

        // GET: GreetingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GreetingController/Delete/5
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
