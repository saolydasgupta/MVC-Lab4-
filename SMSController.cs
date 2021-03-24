using Messaging.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messaging.Controllers
{
    public class SMSController : Controller
    {
        

        // GET: SMS/Details/5
        public ActionResult Details(TextMessage msg)
        {
            return View(msg);
        }

        // GET: SMS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SMS/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TextMessage sms)
        {
            try
            {
                return RedirectToAction("Details",sms);
            }
            catch
            {
                return View();
            }
        }

        
    }
}
