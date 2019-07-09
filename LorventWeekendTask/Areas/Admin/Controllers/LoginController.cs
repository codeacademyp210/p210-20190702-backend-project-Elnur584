using LorventWeekendTask.Areas.Admin.Models;
using LorventWeekendTask.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LorventWeekendTask.Areas.Admin.Controllers
{
   
    public class LoginController : BaseController
    {
        // GET: Admin/Login

    
        [HttpGet]
       
        public ActionResult LoginIndex()
        {
            return View();
                            
        }
        [HttpPost]
       
        public ActionResult LoginIndex(User user)
        {
            var usr = db.User.FirstOrDefault(m => m.Username == user.Username && m.Password == user.Password);
            if (usr != null)
            {
                FormsAuthentication.SetAuthCookie(usr.Username, false);
              return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.Message = "Username Veya Sifre Sehvdir";
                return View();
            }
          

        }
        /// <returns></returns>
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return View("LoginIndex");

        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
            return RedirectToAction("LoginIndex");
        }

    }
}