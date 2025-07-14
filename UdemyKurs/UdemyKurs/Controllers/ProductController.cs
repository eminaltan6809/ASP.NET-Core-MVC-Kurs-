using Microsoft.AspNetCore.Mvc;

namespace UdemyKurs.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
