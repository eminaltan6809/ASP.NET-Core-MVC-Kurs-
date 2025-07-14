using Microsoft.AspNetCore.Mvc;
using UdemyKurs.Models;

namespace UdemyKurs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Emin";
            ViewData["Name"] = "ALTAN";
            TempData["Name"] = "Emin ALTAN";
            Customer customer = new() { Age = 25, Firstname = "Emin", Lastname = "ALTAN" };
            return RedirectToAction("Index","Product", new {@id=1});
        }

        public IActionResult Emin(int id)
        {
            return View();
        }
    }
}
    