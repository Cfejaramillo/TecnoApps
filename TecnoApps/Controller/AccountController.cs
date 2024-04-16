using Microsoft.AspNetCore.Mvc;

namespace TecnoApps.Controller
{
    public class AccountController : ControllerBase
    {
        public IActionResult Login()
        {
            return RedirectToPage("Login");
        }
    }
}
