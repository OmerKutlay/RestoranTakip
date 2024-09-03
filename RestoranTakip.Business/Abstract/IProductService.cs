using RestoranTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Business.Abstract
{
    public interface IProductService
    {
        IQueryable<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        Product Update(Product product);
        bool Delete(int id);
    }
}
