using AspNetCoreIdentityWithCookieAuthentication.Entities;
using AspNetCoreIdentityWithCookieAuthentication.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCoreIdentityWithCookieAuthentication.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManger;
        private readonly SignInManager<User> _signinManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signinManager)
        {
            _userManger = userManager;
            _signinManager = signinManager;
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterViewModel model)
        {
            /*
             * 1. Validate the model
             * 2. Create the User
             * 3. Log the user in
             */

           if(ModelState.IsValid)
            {
                //Create the user with the given user details
                var user = new User { UserName = model.UserName, Email = model.Email };
                //Create the user in the database using identity
                var result = await _userManger.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //User has been successfully created,  now log the user in
                    await _signinManager.SignInAsync(user, false);
                    return RedirectToAction(nameof(HomeController.Index), nameof(HomeController));
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View();

        }

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                //Log the user in
                var result = await _signinManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
                if(result.Succeeded)
                {
                    //Redirect to the movie
                    return RedirectToAction("Index", "Movie");
                }
                else
                {
                    return View(model);
                }                
            }
            else
            {
                //Something is wrong, return the view back to the user
                return View();
            }            
        }

        
        public async Task<IActionResult> Logout()
        {
            //This will  unset the session cookie, so that user gets logged out
            await _signinManager.SignOutAsync();
            //Now the user is an annonymous user, so show him/her safe page
            return RedirectToAction("Index", "Home");
        }
    }
}
