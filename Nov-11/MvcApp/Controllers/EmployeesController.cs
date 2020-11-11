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
        [HttpGet]
        public ActionResult Create()
        {
            //create an object of Employee class
            Employee emp = new Employee();

            //call the view and pass model object to view
            return View(emp);
        }


        //POST:  /Employees/Create: Executes when the user clicks on Save button
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid) //checking all validation rules (built in + custom validations)
            {
                //create object of DbContext
                MvcAppDatabaseDbContext db = new MvcAppDatabaseDbContext();

                //generate new EmpID
                emp.EmpID = Guid.NewGuid();

                //add object to DbSet
                db.Employees.Add(emp);

                //Execute sql
                db.SaveChanges();

                return RedirectToAction("Index", "Employees");
            }
            else
            {
                return View(emp);
            }
        }

        //GET:  /Employees/Edit/id: To show employee-update page
        public ActionResult Edit(Guid? id)
        {
            if (id != null)
            {
                //fetch data from db
                MvcAppDatabaseDbContext db = new MvcAppDatabaseDbContext();
                Employee emp = db.Employees.Where(temp => temp.EmpID == id).FirstOrDefault();

                if (emp != null)
                {
                    // call the view and pass model object to view
                    return View(emp);
                }
                else
                {
                    return Content("Specified Emp ID does not exist");
                }
            }
            else
            {
                return Content("Please supply Emp ID");
            }
        }


        //POST:  /Employees/Edit: Executes when the user clicks on Save button
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid) //checking all validation rules (built in + custom validations)
            {
                //create object of DbContext
                MvcAppDatabaseDbContext db = new MvcAppDatabaseDbContext();

                Employee matchingEmp = db.Employees.Where(temp => temp.EmpID == emp.EmpID).FirstOrDefault();
                if (matchingEmp != null)
                {
                    //Overwrite all details except ID
                    matchingEmp.EmpName = emp.EmpName;
                    matchingEmp.Email = emp.Email;
                    matchingEmp.DateOfJoining = emp.DateOfJoining;
                    matchingEmp.CTCPerHour = emp.CTCPerHour;

                    //Execute sql
                    db.SaveChanges();

                    return RedirectToAction("Index", "Employees");
                }
                else
                {
                    return Content("Emp ID doesn't exist");
                }
            }
            else
            {
                return View(emp);
            }
        }

        //GET:  /Employees/Delete/id: To show only delete employee based id
        public ActionResult Delete(Guid? id)
        {
            if (id != null)
            {
                //fetch data from db
                MvcAppDatabaseDbContext db = new MvcAppDatabaseDbContext();
                Employee emp = db.Employees.Where(temp => temp.EmpID == id).FirstOrDefault();

                if (emp != null)
                {
                    // call the view and pass model object to view
                    return View(emp);
                }
                else
                {
                    return Content("Specified Emp ID does not exist");
                }
            }
            else
            {
                return Content("Please supply Emp ID");
            }
        }


        //POST:  /Employees/Delete: Executes when the user clicks on Delete button
        [HttpPost]
        public ActionResult Delete(Employee emp)
        {
            //create object of DbContext
            MvcAppDatabaseDbContext db = new MvcAppDatabaseDbContext();

            Employee matchingEmp = db.Employees.Where(temp => temp.EmpID == emp.EmpID).FirstOrDefault();
            if (matchingEmp != null)
            {
                //Delete
                db.Employees.Remove(matchingEmp);

                //Execute sql
                db.SaveChanges();

                return RedirectToAction("Index", "Employees");
            }
            else
            {
                return Content("Emp ID doesn't exist");
            }
        }
    }
}

