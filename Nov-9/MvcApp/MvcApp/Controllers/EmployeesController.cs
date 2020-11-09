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


        //GET:  /Employees/Details/id: To show only single employee based id
        //GET:  /Employees/Create: To show employee-insert page
        //GET:  /Employees/Edit/id: To show employee-update page
        //GET:  /Employees/Delete/id: To show only delete employee based id
    }
}

