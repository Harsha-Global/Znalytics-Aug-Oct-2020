using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;

namespace CompanyWebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        public Employee Post(Employee emp)
        {
            EmployeesDataAccess employeesDataAccess = new EmployeesDataAccess();
            int n = employeesDataAccess.InsertEmployee(emp);

            return emp;
        }

        public Employee Put(Employee emp)
        {
            EmployeesDataAccess employeesDataAccess = new EmployeesDataAccess();
            int n = employeesDataAccess.UpdateEmployee(emp);

            return emp;
        }

        public int Delete(int id)
        {
            EmployeesDataAccess employeesDataAccess = new EmployeesDataAccess();
            int n = employeesDataAccess.DeleteEmployee(id);

            return n;
        }

        //To get all employees from database
        public List<Employee> Get()
        {
            EmployeesDataAccess employeesDataAccess = new EmployeesDataAccess();
            List<Employee> employees = employeesDataAccess.GetEmployees();
            return employees;
        }
    }
}
