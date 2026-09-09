using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Osama()
        {
            return View();
        }
    }
}
