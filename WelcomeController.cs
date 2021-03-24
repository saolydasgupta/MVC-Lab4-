using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Welcome.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TimeMessage = "Date:" + DateTime.Now.ToShortDateString() + " Time:" + DateTime.Now.ToShortTimeString();
            return View();
        }
    }
}
