using Microsoft.AspNetCore.Mvc;
using RestoranTakip.Business.Abstract;
using RestoranTakip.Models;

namespace RestoranTakip.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll() 
        {
            return Json(new { data = _productService.GetAll() });
        }

        [HttpPost]
        public IActionResult GetAll(OrderDetail OrderDetail)
        {
            return Json(new {data = _productService.GetAll(OrderDetail)});
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            return Ok(_productService.Add(product));
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            return Ok(_productService.Update(product));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return Ok(_productService.Delete(id));
        }
    }
}
