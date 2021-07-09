using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothingStore.Controllers
{
    [Authorize]
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Create()
        {
            return View();
        }
    }
}