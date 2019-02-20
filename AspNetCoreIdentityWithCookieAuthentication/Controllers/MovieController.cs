using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentityWithCookieAuthentication.Controllers
{
    [Authorize]
    public class MovieController: Controller
    {
        [HttpGet]
        public string Get()
        {
            var result = "{Id:1,Name:'Matrix'}";
            return result;
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}
