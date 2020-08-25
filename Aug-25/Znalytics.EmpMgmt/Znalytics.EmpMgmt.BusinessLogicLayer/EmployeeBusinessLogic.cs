using System;
using System.Collections.Generic;
using Znalytics.EmpMgmt.DataAccessLayer;
using Znalytics.EmpMgmt.Entities;

namespace Znalytics.EmpMgmt.BusinessLogicLayer
{
    public class EmployeeBusinessLogic
    {
        EmployeesDataAccessLogic _employeesDataAccessLogic;
        
        public EmployeeBusinessLogic()
        {
            _employeesDataAccessLogic = new EmployeesDataAccessLogic();
        }

        //Add
        public void Add(Employee employee)
        {
            if (employee.EmployeeName != null)
            {
                _employeesDataAccessLogic.Add(employee);
            }
            else
            {
                throw new Exception("Employee Name can't be null");
            }
        }

        //GetAllEmployees
        public List<Employee> GetEmployees()
        {
            return _employeesDataAccessLogic.GetEmployees();
        }

        public void UpdateEmployee(Employee employee)
        {
            if (employee.EmployeeName != null)
            {
                _employeesDataAccessLogic.UpdateEmployee(employee);
            }
        }


        //subscribed method
        public void UpdateEmployeeName()
        {
            Console.WriteLine("UpdateEmployeeName");
        }
    }
}

