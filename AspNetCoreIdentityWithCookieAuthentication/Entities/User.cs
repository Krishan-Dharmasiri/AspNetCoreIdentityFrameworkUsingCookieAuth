using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentityWithCookieAuthentication.Entities
{
    public class User : IdentityUser
    {
        //Here you can add additional properties that you think your application users need
        //If you don't need additional properties then  you can leave this empty
        //Default IdentityUser means that the Id is string type
    }
}
