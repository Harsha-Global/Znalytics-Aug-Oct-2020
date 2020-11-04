using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DataSetExample
{
    class Program
    {
        static void Main()
        {
            //create an object of SqlConnection class
            SqlConnection sqlConnection = new SqlConnection("Server=localhost; integrated security=yes; initial catalog=company");

            //create an object of SqlCommand class
            SqlCommand sqlCommand = new SqlCommand("deptemp", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //create an object of SqlDataAdapter class
            SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);

            //create an object of DataSet (empty DataSet)
            DataSet ds = new DataSet();

            //Fill: Internally creates necessary objects of DataTable, DataColumn, DataRow, Constraint
            adp.Fill(ds);

            //Read Departments table
            Console.WriteLine("DEPARTMENTS:");
            DataTable dtDepartments = ds.Tables[0];
            for (int i = 0; i < dtDepartments.Rows.Count; i++)
            {
                //getting a row from departments table
                DataRow rowDept = dtDepartments.Rows[i];

                Console.WriteLine(rowDept["DeptNo"] + ", " + rowDept["DeptName"] + ", " + rowDept["Loc"]);
            }

            //Read Employees table
            Console.WriteLine("\nEMPLOYEES:");
            for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
            {
                Console.WriteLine(ds.Tables[1].Rows[i]["EmpID"] + ", " + ds.Tables[1].Rows[i]["EmpName"] + ", " + ds.Tables[1].Rows[i]["Salary"] + ", " + ds.Tables[1].Rows[i]["DeptNo"]);
            }

            Console.ReadKey();
        }
    }
}
