using LorventWeekendTask.Areas.Admin.Models;
using LorventWeekendTask.Areas.Admin.ViewModels;
using LorventWeekendTask.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LorventWeekendTask.Areas.Admin.Controllers
{
    public class NewsController : BaseController
    {
        // GET: Admin/News
        public ActionResult News()
        {
          NewsViewModel model =new  NewsViewModel();
            {
                model.NewsAdd = db.NewsAdds.ToList();
            }
            return View(model);
        }
        public ActionResult AddNews()
        {
            return View();
        }
      
    }
}