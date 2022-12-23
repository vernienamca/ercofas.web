using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Web.Controllers
{
    public class HearingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RequestHearing()
        {
            return View();
        }

        public IActionResult Schedule(int id)
        {
            return View();
        }

        public IActionResult ScheduleSet()
        {
            return View();
        }

        public IActionResult HearingList()
        {
            return View();
        }
    }
}
