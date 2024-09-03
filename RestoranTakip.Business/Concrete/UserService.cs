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
    public class UserService : IUserService
    {
        private readonly IRepository<AppUser> _userRepository;

        public UserService (IRepository<AppUser> userRepository)
        {
            _userRepository = userRepository;
        }
        public AppUser Add(AppUser appuser)
        {
            return _userRepository.Add(appuser);
        }

        public AppUser CheckUser(string username, string password)
        {
            return _userRepository.GetFirstOrDefault(u => u.Name == username && u.Password == password && !u.IsDeleted);
        }

        public bool Delete(int UserId)
        {
            _userRepository.Delete(UserId);
            return true;
        }

        public IQueryable<AppUser> GetAll()
        {
            return _userRepository.GetAll();
        }

        public AppUser Update(AppUser appuser)
        {
            return _userRepository.Update(appuser);
        }
    }
}
