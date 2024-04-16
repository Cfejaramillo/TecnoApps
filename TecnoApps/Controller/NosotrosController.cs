using Microsoft.AspNetCore.Mvc;

namespace TecnoApps.Controller
{
    public class NosotrosController : ControllerBase
    {
        public IActionResult Nosotros()
        {
            return RedirectToPage("Nosotros");
        }
    }
}
