using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
