﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Models
{
    public class Table:BaseModel
    {
       public virtual ICollection<Waiter> Waiters { get; set; }
    }
}
