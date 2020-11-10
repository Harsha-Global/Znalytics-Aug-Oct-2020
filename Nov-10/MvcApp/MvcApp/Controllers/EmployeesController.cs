using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcApp.Models;
using MvcApp.EntityFramework;

namespace MvcApp.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: /Employees/Index: To show all employees (grid)
        public ActionResult Index()
        {
            //create object of DbContext
            MvcAppDatabaseDbContext db = new MvcAppDatabaseDbContext();
            List<Employee> employees = db.Employees
                .OrderBy(temp => temp.EmpName)
                .ToList();

            return View(employees); //Supply model collection to view
        }


        // GET: /Employees/Details/id: To show only single employee based id
        public ActionResult Details(Guid? id)
        {
            if (id != null)
            {
                //create object of DbContext
                MvcAppDatabaseDbContext db = new MvcAppDatabaseDbContext();

                //Get employee based on empid (guid)
                Employee employee = db.Employees
                    .Where(temp => temp.EmpID == id)
                    .FirstOrDefault();

                return View(employee); //Supply model collection to view
            }
            else
            {
                return Content("<h2>ID is not supplied</h2>", "text/html");
            }
        }


        //GET:  /Employees/Create: To show employee-insert page
        public ActionResult Create()
        {
            //create an object of Employee class
            Employee emp = new Employee();

            //call the view and pass model object to view
            return View(emp);
        }


        //GET:  /Employees/Edit/id: To show employee-update page
        //GET:  /Employees/Delete/id: To show only delete employee based id
    }
}

