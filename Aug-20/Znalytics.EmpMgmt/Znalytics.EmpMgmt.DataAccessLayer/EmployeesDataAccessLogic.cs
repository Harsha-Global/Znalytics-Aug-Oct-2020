using System;
using System.Collections.Generic;
using Znalytics.EmpMgmt.Entities;

namespace Znalytics.EmpMgmt.DataAccessLayer
{
    public class EmployeesDataAccessLogic
    {
        //private fields
        private static List<Employee> _employees;

        //constructor
        static EmployeesDataAccessLogic()
        {
            _employees = new List<Employee>()
            {
                new Employee(){ EmployeeID = 101, EmployeeName = "Scott" },
                new Employee(){ EmployeeID = 102, EmployeeName = "Allen" }
            };
        }

        //Add
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        //Get all employees
        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        //Update
        public void UpdateEmployee(Employee employee)
        {
            //Get matching employee based on EmpID
            Employee emp = _employees.Find(temp => temp.EmployeeID == employee.EmployeeID);
            if (emp != null)
            {
                emp.EmployeeName = employee.EmployeeName;
            }
        }
    }
}
