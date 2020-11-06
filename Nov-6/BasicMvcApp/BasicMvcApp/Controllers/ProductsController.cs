using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicMvcApp.Models;

namespace BasicMvcApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products/Details
        //{controller}/{action}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return File("~/Sample.pdf", "application/pdf");
            }
            else
            {
                //controller is responsible to supply data(object of model) to view
                //Controller supplies Model to View
                Product product = new Product() { ProductID = Guid.NewGuid(), ProductName = "iPhone", Price = 200000, Quantity = 10 };
                return View(product); //Calling the view & supplying the model object to view.
            }
        }
    }
}
