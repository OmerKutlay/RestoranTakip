using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using RestoranTakip.Business.Abstract;
using RestoranTakip.Models;
using System.Security.Claims;
using System.Security.Principal;
using RestoranTakip.Business.Concrete;

namespace RestoranTakip.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        { 
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> Login(AppUser user)
        {
            AppUser appUser = _userService.CheckUser(user.Name, user.Password);
            if (appUser != null)
            {
                List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, appUser.Id.ToString()),
            new Claim(ClaimTypes.GivenName, appUser.Name),
            new Claim(ClaimTypes.Role, appUser.IsAdmin ? "Admin" : "User")
        };

                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(new ClaimsPrincipal(identity));

                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false, message = "Geçersiz kullanıcı adı veya şifre." });
            }
        }

        [HttpPost]
        public IActionResult Add(AppUser user)
        {
            return Ok(_userService.Add(user));
        }

        [HttpPost]
        public IActionResult Update(AppUser user)
        {
            return Ok(_userService.Update(user));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return Ok(_userService.Delete(id));
        }

       
        public IActionResult GetAll()
        {
            return Json(new { data = _userService.GetAll() });
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            return Ok(_userService.GetById(id));
        }
    }
}
