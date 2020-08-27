using System;
using System.Collections.Generic;
using EntityLayer;
using DataLogicLayer;

namespace BusinessLogicLayer
{
    public class EmployeeBusinessLogic
    {
        private EmployeeDataLayer _employeeDataLayer;

        public EmployeeBusinessLogic()
        {
            _employeeDataLayer = new EmployeeDataLayer();
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                _employeeDataLayer.AddEmployee(employee);
            }
            catch (FormatException ex)
            {
                throw;
            }
            catch (Exception ex) when (ex.Message == "Unable to add employee because of database connection")
            {
                //throw new Exception("Employee Not Added, try again!", ex);
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

