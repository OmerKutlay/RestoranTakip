using RestoranTakip.Business.Abstract;
using RestoranTakip.Models;
using RestoranTakip.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Business.Concrete
{
    public class StatusService : IStatusService
    {
        private readonly IRepository<Status> _statusRepository;

        public StatusService(IRepository<Status> statusRepository)
        {
            _statusRepository = statusRepository;
        }
        public IQueryable<Status> GetAll()
        {
            return _statusRepository.GetAll(s => !s.IsDeleted);
        }
        public IQueryable<Status> GetAll(Order order)
        {
            return _statusRepository.GetAll(s => s.Orders == order);
        }
        public Status GetById(int id)
        {
            return _statusRepository.GetById(id);
        }
        public Status Add(Status status)
        {
           return _statusRepository.Add(status);
        }
        public Status Update(Status status)
        {
           return _statusRepository.Update(status);
        }
        public bool Delete(int id)
        {
            _statusRepository.Delete(id);
            return true;
        }
    }
}
