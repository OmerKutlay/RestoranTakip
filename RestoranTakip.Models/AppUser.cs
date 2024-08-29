using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Models
{
    public class AppUser:BaseModel
    {
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Table> Tables { get; set; }
    }
}
