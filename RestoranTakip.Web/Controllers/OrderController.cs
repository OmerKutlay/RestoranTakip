using Microsoft.AspNetCore.Mvc;
using RestoranTakip.Business.Abstract;
using RestoranTakip.Models;

namespace RestoranTakip.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll(int tableId)
        {
            return Json(new { data = _orderService.GetAll(tableId) });
        }

        [HttpPost]
        public IActionResult Add(Order order, List<OrderDetail> orderDetails)
        {
            return Ok(_orderService.Add(order, orderDetails));
        }

        [HttpPost]
        public IActionResult Update(Order order, List<OrderDetail> orderDetails)
        {
            return Ok(_orderService.Update(order, orderDetails));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return Ok(_orderService.Delete(id));
        }

        [HttpPost]
        public IActionResult UpdateDetails(int orderId, List<OrderDetail> orderDetails)
        {
            return Ok(_orderService.UpdateDetails(orderId, orderDetails));
        }
    }
}
