using Microsoft.AspNetCore.Mvc;

namespace TecnoApps.Controller
{
    public class IndexController : ControllerBase
    {
        public IActionResult Index()
        {
            return RedirectToPage("Index");
        }
    }
}
