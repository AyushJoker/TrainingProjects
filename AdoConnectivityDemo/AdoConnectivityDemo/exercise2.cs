using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoConnectivityDemo
{
    internal class exercise2
    {
        static void Main()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=ayush\\SQLEXPRESS;initial catalog=NorthWind;integrated security=true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select avg(salary) from employees";
                con.Open();
                decimal avgSalary = (decimal)(cmd.ExecuteScalar());
                Console.WriteLine("Average salary of employees are "+ avgSalary);
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}