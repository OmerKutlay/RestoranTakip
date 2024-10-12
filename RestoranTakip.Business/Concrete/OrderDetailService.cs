using RestoranTakip.Business.Abstract;
using RestoranTakip.Models;
using RestoranTakip.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Business.Concrete
{
    public class OrderDetailService : IOrderDetailService
    {

        private readonly IRepository<OrderDetail> _orderDetailRepository;

        public OrderDetailService(IRepository<OrderDetail> orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public List<OrderDetail> GetAllByOrderId(int orderId)
        {
            return _orderDetailRepository.GetAll(od => od.OrderId == orderId).ToList();
        }

        public OrderDetail Add(OrderDetail orderDetail)
        {
            return _orderDetailRepository.Add(orderDetail);
        }
        public OrderDetail Update(OrderDetail orderDetail)
        {
            return _orderDetailRepository.Update(orderDetail);
        }
        public bool Delete(int id)
        {
            _orderDetailRepository.Delete(id);
            return true;
        }
    }

}
