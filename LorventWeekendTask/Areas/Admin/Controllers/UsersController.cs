using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LorventWeekendTask.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
       
        // GET: Admin/Users
        public ActionResult UserList()
        {
            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }
        public ActionResult AddUsers()
        {
            return View();
        }
        public ActionResult PaymentList()
        {
            return View();
        }
    }
}