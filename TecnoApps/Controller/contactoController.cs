using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace TecnoApps.Controller
{
    public class contactoController : ControllerBase
    {
        public IActionResult contacto()
        {
            return RedirectToPage("contacto");
        }
    }
}
