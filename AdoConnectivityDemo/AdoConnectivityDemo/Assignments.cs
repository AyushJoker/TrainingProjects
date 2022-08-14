//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace AdoConnectivityDemo
//{
//    internal class Assignments
//    {
//        static void Main()
//        {
//            try
//            {
//                SqlConnection con = new SqlConnection("Data Source=ayush\\SQLEXPRESS;initial catalog=NorthWind;integrated security=true");
//                SqlCommand cmd = new SqlCommand();
//                cmd.Connection = con;
//                cmd.CommandText = "update employees set firstname=@frename where employeeid=1";
//                SqlParameter p1 = new SqlParameter("@frename", System.Data.SqlDbType.VarChar);
//                string fname;
//                Console.WriteLine("Enter name");
//                fname = Console.ReadLine();
//                p1.Value = fname;
//                cmd.Parameters.Add(p1);
//                con.Open();
//                cmd.ExecuteNonQuery();
//                Console.WriteLine("Record updated successfully");
//                con.Close();
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}
