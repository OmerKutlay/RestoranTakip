using Microsoft.AspNetCore.Mvc;

namespace RestoranTakip.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
