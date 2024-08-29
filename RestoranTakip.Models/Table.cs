using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Models
{
    public class Table:BaseModel
    {
        public bool IsOccupied { get; set; }
        public virtual ICollection<Waiter> Waiters { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
