using Microsoft.AspNetCore.Mvc;

namespace ERCOFAS.Web.Controllers
{
    public class OnGoingCasesController : Controller
    {
        public IActionResult CasePleadings()
        {
            return View();
        }

        public IActionResult AddCasePleading()
        {
            return View();
        }

        public IActionResult EditCasePleading()
        {
            return View();
        }

        public IActionResult PreFilingList()
        {
            return View();
        }

        public IActionResult PreFilingReview()
        {
            return View();
        }
    }
}
