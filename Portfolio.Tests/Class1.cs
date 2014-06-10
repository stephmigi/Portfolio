//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Portfolio.Tests
//{
//    [TestFixture]
//    public class DbConnectionTests
//    {
//        [Test]
//       public void Connection()
//       {
//           SqlConnection c = new SqlConnection("Server=.\\SQLEXPRESS;Integrated Security=true;Database=SMPortfolio");
//            c.InfoMessage += ( o, e ) => Console.WriteLine( e.Message );
//            c.Open();
//            try
//            {
//                SqlCommand cmd = new SqlCommand();
//                cmd.CommandText = "select * from dbo.Realisation";
//                cmd.CommandType = CommandType.Text;
//                cmd.Connection = c;

//                using (SqlDataReader rdr = cmd.ExecuteReader())
//                {
//                    while (rdr.Read())
//                    {
//                        Console.WriteLine(rdr.GetString(1));
//                        Console.WriteLine(rdr.GetString(rdr.GetOrdinal("Name")));
//                    }
//                }
//            }

        
//        { 
//            catch { }

//       }
//    }
//}
