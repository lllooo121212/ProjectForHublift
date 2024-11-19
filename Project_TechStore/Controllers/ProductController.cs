using Project_TechStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_TechStore.Controllers
{
    public class ProductController : Controller
    {
        private DBTechStoreContext db = new DBTechStoreContext();

        public ActionResult Index()
        {
            var products = db.Products.ToList();
            return View(products);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}