using System;
using System.Data;
using System.Data.SqlClient;
namespace AdoDissConnectedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionstr = "Data Source=ayush; initial catalog=Northwind; integrated security=true";
                SqlConnection con = new SqlConnection(connectionstr);
                SqlDataAdapter da = new SqlDataAdapter("select employeeId,firstname,lastname from employees", con);
                // disconnected Architecture use Data Adapter and no need to open connection
                // explicitly
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(" Id " + row["employeeid"] + "First Name :" + row["firstname"] + "Last Nmae :" + row["lastname"]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}