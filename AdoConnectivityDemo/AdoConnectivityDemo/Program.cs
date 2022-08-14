/*using System;
using System.Data.SqlClient;
using System.Data;

namespace AdoConnectedDemo
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=ayush\\SQLEXPRESS;initial catalog=NorthWind;integrated security=true");
                con.Open();
                Console.WriteLine("Connection Established of connected architecture");
                // step 2 command 
                SqlCommand com = new SqlCommand();
                // step 3 join connection with cmd 
                com.Connection = con;// associate command with connection
                com.CommandText = "select productID,productName from products";
                SqlDataReader dr;
                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("Id : " + dr[0] + "Name : " + dr[1]);
                }
                dr.Close();
                con.Close();
                com.CommandText = "insert into employees(firstname,department)values(@firstname,@dept)";
                SqlParameter p1 = new SqlParameter("@firstname", System.Data.SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@dept", System.Data.SqlDbType.VarChar);
                string fName, deptName;
                Console.WriteLine("Enter First Name\n");
                fName = Console.ReadLine();
                Console.WriteLine("Enter Department Name\n");
                deptName = Console.ReadLine();
                p1.Value = fName;
                p2.Value = deptName;
                com.Parameters.Add(p1);
                com.Parameters.Add(p2)
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}*/