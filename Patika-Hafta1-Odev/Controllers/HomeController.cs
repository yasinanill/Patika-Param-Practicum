using Microsoft.AspNetCore.Mvc;

namespace Patika_Hafta1_Odev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
