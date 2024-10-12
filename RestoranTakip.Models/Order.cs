using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Models
{
    public class Order:BaseModel
    {
        [Required]
        public decimal TotalAmount { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int TableId { get; set; }
        public virtual Table Table { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
       
    }
}
