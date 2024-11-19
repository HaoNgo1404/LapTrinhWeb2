using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LapTrinhWeb.Areas.Admin.Controllers
{
    public class Admin_HomeController : Controller
    {
        // GET: Admin/Admin_Home
        public ActionResult Index()
        {
            return View();
        }
    }
}