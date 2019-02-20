using AspNetCoreIdentityWithCookieAuthentication.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIdentityWithCookieAuthentication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index","Movie");
            }
            else
            {
                return RedirectToAction("Login","Account");
            }
        }
    }
}
