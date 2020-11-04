using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

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
            SqlConnection sqlConnection = new SqlConnection("server=localhost; integrated security=SSPI; initial catalog=company");

            //open the connection
            sqlConnection.Open();

            //create an object of SqlCommand class: used to send an SQL statement to DBMS (sql server) and execute it at DBMS; and get back result
            SqlCommand sqlCommand = new SqlCommand("InsertEmployee", sqlConnection);

            //specify command type
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

            //Create 4 objects of SqlParameter class: to pass dynamic values to the sql statement
            //sqlCommand.Parameters.Add(new SqlParameter("@EmpID", emp.EmpID));
            //sqlCommand.Parameters.Add(new SqlParameter("@EmpName", emp.EmpName));
            //sqlCommand.Parameters.Add(new SqlParameter("@Salary", emp.Salary));
            //sqlCommand.Parameters.Add(new SqlParameter("@DeptNo", emp.DeptNo));

            //Create 4 objects of SqlParameter class: to pass dynamic values to the sql statement
            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@EmpID", emp.EmpID));
            parms.Add(new SqlParameter("@EmpName", emp.EmpName));
            parms.Add(new SqlParameter("@Salary", emp.Salary));
            parms.Add(new SqlParameter("@DeptNo", emp.DeptNo));
            parms[1].Direction = System.Data.ParameterDirection.Input;
            parms[1].SqlDbType = System.Data.SqlDbType.VarChar;

            sqlCommand.Parameters.AddRange(parms.ToArray());

            //execute the SqlCommand: returns no. of rows effected
            int n = sqlCommand.ExecuteNonQuery();

            //close the connection
            sqlConnection.Close();

            return n;
        }


        /// <summary>
        /// This method updates an existing row in "Employees" table
        /// </summary>
        public int UpdateEmployee(Employee emp)
        {
            //create an object of SqlConnection class: used to connect to "company" database
            SqlConnection sqlConnection = new SqlConnection("server=localhost; integrated security=SSPI; initial catalog=company");

            //open the connection
            sqlConnection.Open();

            //create an object of SqlCommand class: used to send an SQL statement to DBMS (sql server) and execute it at DBMS; and get back result
            SqlCommand sqlCommand = new SqlCommand("UpdateEmployee", sqlConnection);

            //specify command type
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

            //Create 4 objects of SqlParameter class: to pass dynamic values to the sql statement
            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@EmpID", emp.EmpID));
            parms.Add(new SqlParameter("@EmpName", emp.EmpName));
            parms.Add(new SqlParameter("@Salary", emp.Salary));
            parms.Add(new SqlParameter("@DeptNo", emp.DeptNo));

            sqlCommand.Parameters.AddRange(parms.ToArray());

            //execute the SqlCommand: returns no. of rows effected
            int n = sqlCommand.ExecuteNonQuery();

            //close the connection
            sqlConnection.Close();

            return n;
        }

        /// <summary>
        /// This method deletes an existing row in "Employees" table
        /// </summary>
        public int DeleteEmployee(int EmpID)
        {
            //create an object of SqlConnection class: used to connect to "company" database
            SqlConnection sqlConnection = new SqlConnection("server=localhost; integrated security=SSPI; initial catalog=company");

            //open the connection
            sqlConnection.Open();

            //create an object of SqlCommand class: used to send an SQL statement to DBMS (sql server) and execute it at DBMS; and get back result
            SqlCommand sqlCommand = new SqlCommand("DeleteEmployee", sqlConnection);

            //specify command type
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

            //Create 1 object of SqlParameter class: to pass dynamic values to the sql statement
            sqlCommand.Parameters.Add(new SqlParameter("@EmpID", EmpID));

            //execute the SqlCommand: returns no. of rows effected
            int n = sqlCommand.ExecuteNonQuery();

            //close the connection
            sqlConnection.Close();

            return n;
        }

        public int GetEmployeesCount()
        {
            //create object of SqlConnection class - and also initialize connection string
            SqlConnection sqlConnection = new SqlConnection("Server=localhost; integrated security=yes; initial catalog=company; pooling=true");

            //create object of SqlCommand class - and also initialize CommandText and Connection properties
            SqlCommand sqlCommand = new SqlCommand("GetEmployeesCount", sqlConnection) { CommandType  = System.Data.CommandType.StoredProcedure };

            //specify CommandType
            //sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

            //open the connection
            sqlConnection.Open();

            //ExecuteScaler
            object obj = sqlCommand.ExecuteScalar();
            int n = System.Convert.ToInt32(obj);

            //close the connection
            sqlConnection.Close();

            return n;
        }


        //To get all employees from database
        public List<Employee> GetEmployees()
        {
            //create object of SqlConnection class - and also initialize connection string
            SqlConnection sqlConnection = new SqlConnection("Server=localhost; integrated security=yes; initial catalog=company; pooling=true");

            //create object of SqlCommand class - and also initialize CommandText and Connection properties
            SqlCommand sqlCommand = new SqlCommand("GetAllEmployees", sqlConnection) { CommandType = System.Data.CommandType.StoredProcedure };

            //open the connection
            sqlConnection.Open();

            //ExecuteScaler
            SqlDataReader dataReader = sqlCommand.ExecuteReader(); //this method creates and returns an object of SqlDataReader class

            //Create a blank collection of Employee
            List<Employee> employees = new List<Employee>();

            //read rows one-by-one
            while (dataReader.Read()) //read next record
            {
                //read values from the columns
                int empID = Convert.ToInt32(dataReader["EmpID"]);
                string empName = Convert.ToString(dataReader["EmpName"]);
                decimal salary = Convert.ToDecimal(dataReader["Salary"]);
                int deptNo = Convert.ToInt32(dataReader["DeptNo"]);

                if (dataReader.IsDBNull(1) == true)
                {

                }

                //create object of Employee class
                Employee emp = new Employee() { EmpID = empID, EmpName = empName, Salary = salary, DeptNo = deptNo };

                //add object to collection
                employees.Add(emp);
            }

            //In case of multiple select statements in the stored proc, use this following code for moving to next table.
            //dataReader.NextResult();
            //while (dataReader.Read())
            //{
            //}
            

            //close the connection
            sqlConnection.Close();

            return employees;
        }

        //TO DO: Write a Get method for getting single employee based on empid. 
        //Employee GetEmployeeByEmpID(int EmpID)

        //TO DO: Write a Get method for getting one or more employees based on matching empname (search)
        //List<Employee> GetEmployeesByEmpName(string EmpName)
        //s = all employees that matches with "s"
    }
}

