using Microsoft.EntityFrameworkCore;
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
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order Add(Order order, List<OrderDetail> orderDetails)
        {
           _orderRepository.Add(order);
            foreach (var item in orderDetails)
            {
                item.OrderId = order.Id;
            }
            order.OrderDetails = orderDetails;
            _orderRepository.Update(order);
            return order;
        }

        public bool Delete(int orderId)
        {
            _orderRepository.Delete(orderId);
            return true;
        }

        public ICollection<Order> GetAll(int tableId)
        {
            return _orderRepository.GetAll(o => o.TableId ==tableId).ToList();
        }

        public Order GetById(int orderId)
        {
            return _orderRepository.GetAll(o => o.Id == orderId).Include(o => o.OrderDetails).First();
        }

        public Order Update(Order order, List<OrderDetail> orderDetails)
        {
           order.OrderDetails = new List<OrderDetail>();
            _orderRepository.Update(order);

            order.OrderDetails = orderDetails;
            return _orderRepository.Update(order);
        }

        public Order UpdateAttendees(int orderId, List<OrderDetail> orderDetails)
        {
            Order order = _orderRepository.GetById(orderId);
            order.OrderDetails = orderDetails;
            return _orderRepository.Update(order) ;
        }
    }
}
