using Microsoft.AspNetCore.Mvc;

namespace ERCOFAS.Web.Controllers
{
    public class UserManagementController : Controller
    {
        public IActionResult Pages()
        {
            return View();
        }

        public IActionResult EditPage()
        {
            return View();
        }

        public IActionResult Roles()
        {
            return View();
        }

        public IActionResult AddRole()
        {
            return View();
        }

        public IActionResult EditRole()
        {
            return View();
        }
    }
}
