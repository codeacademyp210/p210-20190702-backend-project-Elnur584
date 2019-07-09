using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LorventWeekendTask.Areas.Admin.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Admin/Gallery
        public ActionResult AddGallery()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
    }
}