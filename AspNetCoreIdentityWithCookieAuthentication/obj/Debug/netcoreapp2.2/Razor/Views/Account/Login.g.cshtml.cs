#pragma checksum "C:\Krishantha\Projects\net core\AspNetCoreIdentity_UserManagement_UsingSessionCookie\AspNetCoreIdentityWithCookieAuthentication\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69679cbfd08cbe5fb3dc591f4fa74e4364a4b104"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69679cbfd08cbe5fb3dc591f4fa74e4364a4b104", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoreIdentityWithCookieAuthentication.ViewModels.LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Krishantha\Projects\net core\AspNetCoreIdentity_UserManagement_UsingSessionCookie\AspNetCoreIdentityWithCookieAuthentication\Views\Account\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(109, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(129, 30, false);
#line 6 "C:\Krishantha\Projects\net core\AspNetCoreIdentity_UserManagement_UsingSessionCookie\AspNetCoreIdentityWithCookieAuthentication\Views\Account\Login.cshtml"
   Write(Html.LabelFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(159, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(170, 32, false);
#line 7 "C:\Krishantha\Projects\net core\AspNetCoreIdentity_UserManagement_UsingSessionCookie\AspNetCoreIdentityWithCookieAuthentication\Views\Account\Login.cshtml"
   Write(Html.TextBoxFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(202, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(213, 42, false);
#line 8 "C:\Krishantha\Projects\net core\AspNetCoreIdentity_UserManagement_UsingSessionCookie\AspNetCoreIdentityWithCookieAuthentication\Views\Account\Login.cshtml"
   Write(Html.ValidationMessageFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(255, 33, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(289, 30, false);
#line 11 "C:\Krishantha\Projects\net core\AspNetCoreIdentity_UserManagement_UsingSessionCookie\AspNetCoreIdentityWithCookieAuthentication\Views\Account\Login.cshtml"
   Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(319, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(330, 33, false);
#line 12 "C:\Krishantha\Projects\net core\AspNetCoreIdentity_UserManagement_UsingSessionCookie\AspNetCoreIdentityWithCookieAuthentication\Views\Account\Login.cshtml"
   Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(363, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(374, 42, false);
#line 13 "C:\Krishantha\Projects\net core\AspNetCoreIdentity_UserManagement_UsingSessionCookie\AspNetCoreIdentityWithCookieAuthentication\Views\Account\Login.cshtml"
   Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(416, 84, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" value=\"Login\" />\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\Krishantha\Projects\net core\AspNetCoreIdentity_UserManagement_UsingSessionCookie\AspNetCoreIdentityWithCookieAuthentication\Views\Account\Login.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreIdentityWithCookieAuthentication.ViewModels.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591