using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
<<<<<<< HEAD
            return RedirectToAction("Index", "Song");
=======
            return RedirectToAction("Index", "Songs");
>>>>>>> ff8b93d21a81731569d5e6f2fff9cfec9e6200fb
        }
    }
}
