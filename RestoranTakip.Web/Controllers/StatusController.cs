using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestoranTakip.Business.Abstract;
using RestoranTakip.Models;

namespace RestoranTakip.Web.Controllers
{
    [Authorize]
    public class StatusController : Controller
    {

        private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new { data = _statusService.GetAll() });
        }

        [HttpPost]
        public IActionResult Add(Status status)
        {
            return Ok(_statusService.Add(status));
        }

        [HttpPost]
        public IActionResult Update(Status status)
        {
            return Ok(_statusService.Update(status));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _statusService.Delete(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {

            return Ok(_statusService.GetById(id));
        }
    }
}
