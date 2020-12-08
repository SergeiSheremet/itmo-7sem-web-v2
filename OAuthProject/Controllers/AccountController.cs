using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;

namespace OAuthProject.Controllers
{
    [AllowAnonymous, Route("account")]
    public class AccountController : Controller
    {
        [Route("google-login")]
        public IActionResult GoogleLogin()
        {
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("GoogleResponse") };

            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        [Route("google-response")]
        public async Task<IActionResult> GoogleResponse()
        {
            await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index","Home");
        }
    }
}
