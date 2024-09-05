using RestoranTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Business.Abstract
{
    public interface ITableService
    {
        Table Add(Table table);
        Table Update(Table table);
        bool Delete(int TableId);
        IQueryable<Table> GetAll(int UserId);

    }
}
