using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TaskList.DAL;
using TaskList.Domain;

namespace TaskList.Web.Controllers
{
    public class AuthenticationsController : Controller
    {
        private readonly TaskListDbContext _context;

        public AuthenticationsController(TaskListDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Login(UserEntity userEntity)
        {
            var info = _context.UserEntities.FirstOrDefault(x => x.Username == userEntity.Username &&
                                                           x.Password == userEntity.Password);
            if (info != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userEntity.Username)

                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Tasks");
            }

            return View();
        }
    }
}
