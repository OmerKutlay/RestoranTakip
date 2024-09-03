using Microsoft.PowerBI.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Business.Abstract
{
    public interface IUserService
    {
        AppUser Add(AppUser appuser);
        AppUser Update(AppUser appuser);
        bool Delete(AppUser appuser);
        AppUser CheckUser(string username, string password);
    }
}
