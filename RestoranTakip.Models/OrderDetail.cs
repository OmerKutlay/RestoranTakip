﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Models
{
    public class OrderDetail:BaseModel
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        
    }
}
