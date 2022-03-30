using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService_Ado.net
{
    class EmployeeRepo
    {
        private static string connectionString = @"Data Source=(Localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(connectionString);

        public void checkConnection()
        {
            try
            {
                this.connection.Open();
                Console.WriteLine("connection established");
                this.connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}