using Microsoft.AspNetCore.Mvc;
using RestoranTakip.Business.Abstract;
using RestoranTakip.Models;
using System.Security.Claims;

namespace RestoranTakip.Web.Controllers
{
    public class TableController : Controller
    {
        private readonly ITableService _tableService;

        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(_tableService.GetAll(int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)));
        }

        [HttpPost]
        public IActionResult Add(Table table)
        {
            return Ok(_tableService.Add(table));
        }

        [HttpPost]
        public IActionResult Update(Table table)
        {
            return Ok(_tableService.Update(table));
        }

        [HttpPost]
        public IActionResult SoftDelete(int id)
        {
            _tableService.Delete(id);
            return Ok();
        }
    }
}
