//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace AdoConnectivityDemo
//{
//    internal class Assignment2
//    {
//        static void Main()
//        {
//            try
//            {
//                SqlConnection con = new SqlConnection("Data Source=ayush\\SQLEXPRESS;initial catalog=NorthWind;integrated security=true");
//                SqlCommand cmd = new SqlCommand();
//                cmd.Connection = con;
//               // cmd.CommandText = "CREATE TABLE Product(ProductID int,ProductName varchar(200),Price int)";
               
//                cmd.CommandText = "insert into Product(productid,productname,price)values(@productid,@name,@price)";

//                SqlParameter p1 = new SqlParameter("productid", System.Data.SqlDbType.Int);
//                SqlParameter p2 = new SqlParameter("@name", System.Data.SqlDbType.VarChar);
//                SqlParameter p3 = new SqlParameter("@price", System.Data.SqlDbType.Int);
//                string name;
//                int price, id;
//                Console.WriteLine("Enter product Name\n");
//                name = Console.ReadLine();
//                Console.WriteLine("Enter id\n");
//                id = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter price\n");
//               price= int.Parse(Console.ReadLine());
//                p1.Value =id;
//                p2.Value = name;
//                p3.Value = price;
//                cmd.Parameters.Add(p1);
//                cmd.Parameters.Add(p2);
//                cmd.Parameters.Add(p3);
//                con.Open();
//                cmd.ExecuteNonQuery();
//                Console.WriteLine("data inserted successfully");
//                con.Close();
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}