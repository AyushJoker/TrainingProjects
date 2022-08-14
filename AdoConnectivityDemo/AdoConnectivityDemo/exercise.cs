//using System;
//using System.Data.SqlClient;
//using System.Data;

//namespace AdoConnectedDemo
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            try
//            {
//                SqlConnection con = new SqlConnection("Data Source=ayush\\SQLEXPRESS;initial catalog=NorthWind;integrated security=true");
//                SqlCommand com = new SqlCommand();
//                com.Connection = con;
//                com.CommandText = "insert into employees(firstname,city,lastname)values(@firstname,@city,@lastname)";
//                SqlParameter p1 = new SqlParameter("@firstname", System.Data.SqlDbType.VarChar);
//                SqlParameter p2 = new SqlParameter("@city", System.Data.SqlDbType.VarChar);
//                SqlParameter p3 = new SqlParameter("@lastname", System.Data.SqlDbType.VarChar);
//                string fName,lname, cityName;
//                Console.WriteLine("Enter First Name\n");
//                fName = Console.ReadLine();
//                Console.WriteLine("Enter City Name\n");
//                cityName = Console.ReadLine();
//                Console.WriteLine("Enter Last Name\n");
//                lname = Console.ReadLine();
//                p1.Value = fName;
//                p2.Value = cityName;
//                p3.Value = lname;
//                com.Parameters.Add(p1);
//                com.Parameters.Add(p2);
//                com.Parameters.Add(p3);
//                con.Open();
//                com.ExecuteNonQuery();
//                Console.WriteLine("Record added successfully");
//                con.Close();
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }

//}