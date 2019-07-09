using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LorventWeekendTask.Areas.Admin.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Admin/Home
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult ClubInfo()
        {
            return View();
        }
        [Authorize]
        public ActionResult Packages()
        {
            return View();
        }
        [Authorize]
        public ActionResult PersonalTraining()
        {
            return View();
        }
        [Authorize]
        public ActionResult Coupons()
        {
            return View();
        }
        [Authorize]
        public ActionResult ClassCalendar()
        {
            return View();
        }
    }
}