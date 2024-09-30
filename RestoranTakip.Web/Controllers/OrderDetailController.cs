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
            var orderDetails = _orderDetailService.GetAllByOrderId(orderId);
            return Json(new { data = orderDetails });
        }

        [HttpPost]
        public IActionResult Add([FromBody] OrderDetail orderDetail)
        {
            if (orderDetail == null)
                return BadRequest("Geçersiz veri");

            var addedOrderDetail = _orderDetailService.Add(orderDetail);
            return Ok(addedOrderDetail);
        }
        [HttpPost]
        public IActionResult Update([FromBody] OrderDetail orderDetail)
        {
            if (orderDetail == null)
                return BadRequest("Geçersiz veri");

            var updatedOrderDetail = _orderDetailService.Update(orderDetail);
            return Ok(updatedOrderDetail);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            bool isDeleted = _orderDetailService.Delete(id);
            if (!isDeleted)
                return NotFound("OrderDetail bulunamadı");

            return Ok();
        }

    }
}
