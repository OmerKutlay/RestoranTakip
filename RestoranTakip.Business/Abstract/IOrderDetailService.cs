using RestoranTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Business.Abstract
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetAllByOrderId(int orderId);
        OrderDetail Add(OrderDetail orderDetail);
        OrderDetail Update(OrderDetail orderDetail);
        bool Delete(int id);
    }
}
