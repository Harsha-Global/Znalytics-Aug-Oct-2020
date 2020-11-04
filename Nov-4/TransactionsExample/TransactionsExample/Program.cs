using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TransactionsExample
{
    class Program
    {
        static void Main()
        {
            //Create an object of SqlConnection class
            SqlConnection connection = new SqlConnection("data source=localhost; integrated security=SSPI; initial catalog=transactionsdemo");

            //Create two objects of SqlCommand class
            SqlCommand sqlCommand1 = new SqlCommand("insert into transactionsdemo.dbo.TicketBookings values(newid(), 'D1')", connection);
            SqlCommand sqlCommand2 = new SqlCommand("insert into transactionsdemo.dbo.Payments values(newid(), 200)", connection);

            //Open the connection
            connection.Open();

            //Begin a transaction based on existing connection.
            //The  BeginTransaction automatically creates an object of SqlTransaction
            SqlTransaction transaction = connection.BeginTransaction();

            //Make both commands as part of the same transaction
            sqlCommand1.Transaction = transaction;
            sqlCommand2.Transaction = transaction;

            try
            {
                sqlCommand1.ExecuteNonQuery(); //Insert into TicketBookings table

                throw new Exception("some error");

                sqlCommand2.ExecuteNonQuery(); //Insert into Payments table

                transaction.Commit(); //Save data
            }
            catch (Exception)
            {
                transaction.Rollback(); //Cancel the inserted row of TicketBookings table
            }

            connection.Close();
            Console.WriteLine("Ticket Booking Completed");
            Console.ReadKey();
        }
    }
}

