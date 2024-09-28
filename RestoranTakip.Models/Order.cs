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
        public DateTime OrderDate { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int TableId { get; set; }
        public virtual Table Table { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
       
    }
}
