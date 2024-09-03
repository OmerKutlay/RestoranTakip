using Microsoft.AspNetCore.Mvc;
using RestoranTakip.Data;
using RestoranTakip.Web.Models;
using System.Diagnostics;

namespace RestoranTakip.Web.Controllers
{
    
    public class deneme : Controller
    {
        private readonly ApplicationDbContext _context;


        public  deneme(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
