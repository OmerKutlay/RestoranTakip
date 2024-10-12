using RestoranTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Business.Abstract
{
    public interface IOrderService
    {
        Order Add(Order order, List<OrderDetail> orderDetails);
        Order Update(Order order, List<OrderDetail> orderDetails);
        Order UpdateDetails(int orderId, List<OrderDetail> orderDetails);
        bool Delete(int orderId);
        ICollection<Order> GetAllByTable(int tableId);
        IQueryable<Order> GetAll();
        Order GetById(int orderId);
    }
}
