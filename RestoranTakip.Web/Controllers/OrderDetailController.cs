using Microsoft.AspNetCore.Mvc;
using RestoranTakip.Business.Abstract;
using RestoranTakip.Models;

namespace RestoranTakip.Web.Controllers
{
    public class OrderDetailController : Controller
    {

        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet]
        public IActionResult GetAllByOrderId(int orderId)
        {
            return Ok(new { data = _orderDetailService.GetAllByOrderId(orderId) });
        }

        [HttpPost]
        public IActionResult Add(OrderDetail orderDetail)
        {
            return Ok(_orderDetailService.Add(orderDetail));
        }
        [HttpPost]
        public IActionResult Update(OrderDetail orderDetail)
        {
            return Ok(_orderDetailService.Update(orderDetail));
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _orderDetailService.Delete(id);
            return Ok();
        }

    }
}
