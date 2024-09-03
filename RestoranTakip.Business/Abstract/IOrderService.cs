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
        Order Update(Order order);
        bool Delete(Order orderId);
        ICollection<Order> GetAll(int tableId);
        Order GetById(int orderId);
    }
}
