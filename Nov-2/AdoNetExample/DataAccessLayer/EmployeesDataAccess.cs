using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// Contains methods to manipulate "Employees" table
    /// </summary>
    public class EmployeesDataAccess
    {
        /// <summary>
        /// This method insert a new row into "Employees" table
        /// </summary>
        public int InsertEmployee(Employee emp)
        {
            //create an object of SqlConnection class: used to connect to "company" database
            SqlConnection sqlConnection = new SqlConnection();

            //specify connection string (details of connection)
            sqlConnection.ConnectionString = "server=localhost; integrated security=SSPI; initial catalog=company";

            //open the connection
            sqlConnection.Open();

            //create an object of SqlCommand class: used to send an SQL statement to DBMS (sql server) and execute it at DBMS; and get back result
            SqlCommand sqlCommand = new SqlCommand();

            //set sql statement
            sqlCommand.CommandText = "insert into Employees(EmpID, EmpName, Salary, DeptNo) values(@EmpID, @EmpName, @Salary, @DeptNo)";

            //set relation between object of SqlConnection and object of SqlCommand
            sqlCommand.Connection = sqlConnection;

            //Create 4 objects of SqlParameter class: to pass dynamic values to the sql statement
            SqlParameter parameter1 = new SqlParameter();
            SqlParameter parameter2 = new SqlParameter();
            SqlParameter parameter3 = new SqlParameter();
            SqlParameter parameter4 = new SqlParameter();

            //specify parameter name
            parameter1.ParameterName = "@EmpID";
            parameter2.ParameterName = "@EmpName";
            parameter3.ParameterName = "@Salary";
            parameter4.ParameterName = "@DeptNo";

            //specify values
            parameter1.Value = emp.EmpID;
            parameter2.Value = emp.EmpName;
            parameter3.Value = emp.Salary;
            parameter4.Value = emp.DeptNo;

            //add parameter objects to command object
            sqlCommand.Parameters.Add(parameter1);
            sqlCommand.Parameters.Add(parameter2);
            sqlCommand.Parameters.Add(parameter3);
            sqlCommand.Parameters.Add(parameter4);

            //execute the SqlCommand: returns no. of rows effected
            int n = sqlCommand.ExecuteNonQuery();

            //close the connection
            sqlConnection.Close();

            return n;
        }
    }
}
