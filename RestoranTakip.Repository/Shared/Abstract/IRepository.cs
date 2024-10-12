using RestoranTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Repository.Shared.Abstract
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        T Add(T entity);
        T Update(T entity);
        void Delete(int id);
        List<T> AddRange(List<T> entities);
        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);
        void Save();
    }
}
