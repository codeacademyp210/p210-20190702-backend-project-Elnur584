using LorventWeekendTask.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LorventWeekendTask.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
        protected AreaContext db;
        public BaseController()
        {
            db = new AreaContext();
        }
        
    }
}