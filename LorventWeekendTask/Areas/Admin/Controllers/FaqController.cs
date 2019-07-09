using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LorventWeekendTask.Areas.Admin.Controllers
{
    public class FaqController : Controller
    {
        // GET: Admin/Faq
        public ActionResult Faqq()
        {
            return View();
        }
        public ActionResult AddFaq()
        {
            return View();
        }
    }
}