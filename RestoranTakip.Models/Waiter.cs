using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Models
{
    public class Waiter:BaseModel
    {
        public virtual ICollection<Table> Tables { get; set; }
    }
}
