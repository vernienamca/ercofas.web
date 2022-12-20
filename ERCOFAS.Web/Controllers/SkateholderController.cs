using Microsoft.AspNetCore.Mvc;

namespace ERCOFAS.Web.Controllers
{
    public class SkateholderController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }
    }
}
