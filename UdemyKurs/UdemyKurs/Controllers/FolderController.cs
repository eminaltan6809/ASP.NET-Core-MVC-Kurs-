using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace UdemyKurs.Controllers
{
    public class FolderController : Controller
    {
        public IActionResult List()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));

            var folders = directoryInfo.GetDirectories();

            return View(folders);
        }
    }
}
