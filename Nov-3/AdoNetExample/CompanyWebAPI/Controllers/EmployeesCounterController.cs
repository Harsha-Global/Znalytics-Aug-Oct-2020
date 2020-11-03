using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;

namespace CompanyWebAPI.Controllers
{
    public class EmployeesCounterController : ApiController
    {
        //GET: http://localhost:52924/api/EmployeesCounter
        public int Get()
        {
            EmployeesDataAccess employeesDataAccess = new EmployeesDataAccess();
            int n = employeesDataAccess.GetEmployeesCount();
            return 100; //giving response from APIController to client
        }
    }
}
