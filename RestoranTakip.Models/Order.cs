using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Models
{
    public class Order:BaseModel
    {
        public decimal TotalAmount { get; set; }
        public int AppUserId { get; set; }
        public int TableId { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
       
    }
}
