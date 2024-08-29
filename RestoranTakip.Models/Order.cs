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
        public int TableId { get; set; }
        public virtual Table Table { get; set; }
    }
}
