using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HACK_MVC_BOOKSTORE_EF.Areas.AdminCP.Controllers
{
    public class HomeController : Controller
    {
        // GET: AdminCP/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}