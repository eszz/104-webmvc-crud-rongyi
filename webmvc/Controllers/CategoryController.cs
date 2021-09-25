using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webmvc.Models;

namespace webmvc.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            List<Category> categories = CategoryDataContext.LoadCategories();
            return View(categories);
        }
    }
}