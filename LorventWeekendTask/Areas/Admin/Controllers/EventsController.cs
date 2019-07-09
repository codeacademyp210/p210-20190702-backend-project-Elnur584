
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LorventWeekendTask.Areas.Admin.Controllers
{
    public class EventsController : Controller
    {
        // GET: Admin/Events
        public ActionResult EventsList()
        {
            return View();
        }
        public ActionResult EventsItem()
        {
            return View();
        }
    }
}