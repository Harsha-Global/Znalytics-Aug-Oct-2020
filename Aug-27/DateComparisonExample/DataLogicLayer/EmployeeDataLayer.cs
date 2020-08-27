using EntityLayer;
using System;
using System.Collections.Generic;

namespace DataLogicLayer
{
    public class EmployeeDataLayer
    {
        private List<Employee> _employees;

        public EmployeeDataLayer()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            //throw new EmployeeException("Unable to add employee because of database connection");
            _employees.Add(employee);
        }
    }
}
