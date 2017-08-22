using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelEF.DAO;
using ModelEF.EF;
namespace HACK_MVC_BOOKSTORE_EF.Areas.AdminCP.Controllers
{
    public class CategoryController : Controller
    {
        // GET: AdminCP/Category
        private CategoryDAO cateDAO = new CategoryDAO();
        public ActionResult Index()
        {
            ViewData["ListCate"] = cateDAO.getAll();
            return View();
        }
    }
}