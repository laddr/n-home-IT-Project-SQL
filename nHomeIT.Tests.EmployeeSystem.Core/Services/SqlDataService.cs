using System;                     // For system functions like Console.
using System.Collections.Generic; // For generic collections like List.
using System.Data.SqlClient;      // For the database connections and objects.
using nHomeIT.Tests.EmployeeSystem.Core;

namespace nHomeIT.Tests.EmployeeSystem.Core.Services
{


    partial class SqlDataService
    {
        //This method will return list of all the employees from the database
        public List<Employee> getEmployees()
        {
            ///This will check if a table exist 
            int check = checkEmployeeTable();
            var employees = new List<Employee>();

            //if table doesn't exist create table
            if (check == 0)
            {
                CreateEmployeeTable();
                check = checkEmployeeTable();
            }
            if (check == 1)
            {
                ///Source for help: https://stackoverflow.com/questions/21709305/how-to-directly-execute-sql-query-in-c-have-example-batch-file/21709663 
                using (SqlConnection con = new SqlConnection(
                    nHomeIT.Tests.EmployeeSystem.Core.Properties.Settings.Default.ConnectionString))
                {
                    string query = "SELECT * FROM EMPLOYEE;";
                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            var e = new Employee();
                            ///Next lets parse the sql data into a an employee object and add to employees list
                            e.EmployeeID = Int32.Parse(reader[0].ToString());
                            e.Username = reader[1].ToString();
                            e.Password = reader[2].ToString();
                            e.FirstName = reader[3].ToString();
                            e.LastName = reader[4].ToString();
                            e.DateOfBirth = Convert.ToDateTime(reader[5].ToString());
                            e.IsActive = Convert.ToBoolean(reader[6].ToString());
                            e.AccessLevel = (AccessLevel)Int32.Parse(reader[7].ToString());
                            employees.Add(e);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Something went wrong when checking table");
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
            }

            return employees;
        }

        ///This method checks if the employee table was already created
        public int checkEmployeeTable()
        {
            int check = -1;
            ///Source for help: https://stackoverflow.com/questions/21709305/how-to-directly-execute-sql-query-in-c-have-example-batch-file/21709663
            ///This will check if a table exist  
            using (SqlConnection con = new SqlConnection(
                nHomeIT.Tests.EmployeeSystem.Core.Properties.Settings.Default.ConnectionString))
            {
                string query = "DECLARE @check int; IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES " +
                    "WHERE TABLE_NAME = 'Employee')" + "SET @check = 1; " + "ELSE SET @check = 0; SELECT @check";
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        ///this converts the reader object to a string and then to an int 
                        check = Int32.Parse(reader[0].ToString());
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong when checking table");
                }
                finally
                {
                    reader.Close();
                }
            }
            return check;
        }

        #region Create Tables
        /**************************************
         * This creates a new employee table  *
         * with employeeID as the primary key *
         *************************************/
        public void CreateEmployeeTable()
        {
            string create = "CREATE TABLE Employee (EmployeeID INT, Username TEXT, Password TEXT, " +
                "FirstName TEXT, LastName TEXT, DateofBirth DATE, IsActive BIT, AccessLevel INT, PRIMARY KEY (EmployeeID));" +
                "INSERT INTO Employee (EmployeeID, Username, Password, FirstName, LastName, DateofBirth, IsActive, AccessLevel)" +
                "VALUES(1, 'admin', 'admin123', 'Admin', 'Employee', '1980-1-1', 1, 1)," +              
                "(2, 'manager', 'manager123', 'Manager', 'Employee', '1985-2-5', 1, 2)," +
                "(3, 'basic', 'basic123', 'Basic', 'Employee', '1990-3-10', 1, 3)," +
                "(4, 'terminated', 'terminated123', 'Terminated', 'Employee', '1990-4-15', 0, 3); ";
            using (SqlConnection con = new SqlConnection(
                nHomeIT.Tests.EmployeeSystem.Core.Properties.Settings.Default.ConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(create, con))
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Employee Table not created.");
                }
            }
        }
    }
    #endregion

}
