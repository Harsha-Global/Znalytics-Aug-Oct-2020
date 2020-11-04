using System;

namespace DataAccessLayer
{
    /// <summary>
    /// Model class that represents a row "Employees" table
    /// </summary>
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public int DeptNo { get; set; }
    }
}
