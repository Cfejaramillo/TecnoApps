using Microsoft.AspNetCore.Mvc;

namespace TecnoApps.Controller
{
    public class ServiciosController : ControllerBase
    {
        public IActionResult Servicios()
        {
            
            return RedirectToPage("Servicios");
        }
    }
}
