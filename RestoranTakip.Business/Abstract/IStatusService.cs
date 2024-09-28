using RestoranTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Business.Abstract
{
    public interface IStatusService
    {
        IQueryable<Status> GetAll();
        IQueryable<Status> GetAll(Order order);
        Status GetById(int id);
        Status Add(Status status);
        Status Update(Status status);
        bool Delete(int id);
    }
}
