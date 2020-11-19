using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.MvcBusinessLayer;
using WebApplication1.ServiceReference1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();
            Product product = productsBusinessLayer.GetProductByProductID(1);

            return View(product);
        }
    }
}