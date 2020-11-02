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
    }
}
