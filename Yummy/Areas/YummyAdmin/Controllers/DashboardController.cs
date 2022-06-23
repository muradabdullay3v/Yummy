using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yummy.Areas.YummyAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("YummyAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
