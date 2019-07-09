using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LorventWeekendTask.Areas.Admin.Controllers
{
    public class CourseScheduleController : Controller
    {
        // GET: Admin/CourseSchedule
        public ActionResult CourseScheduleindex()
        {
            return View();
        }
        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult Rooms()
        {
            return View();
        }
        public ActionResult Trainers()
        {
            return View();
        }
    }
}