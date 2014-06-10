using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel.Database
{
    public class DbConnect
    {
            //public void ExecuteQuery(string query)
            //{
            //    SqlConnection c = new SqlConnection("Server=.\\SQLEXPRESS;Integrated Security=true;Database=SMPortfolio");
            //    c.Open();

            //    try
            //    {
            //        SqlCommand cmd = new SqlCommand();
            //        cmd.CommandText = query;
            //        cmd.CommandType = CommandType.Text;
            //        cmd.Connection = c;

            //        using (SqlDataReader rdr = cmd.ExecuteReader())
            //        {
            //            while (rdr.Read())
            //            {
            //                Console.WriteLine(rdr.GetString(1));
            //                Console.WriteLine(rdr.GetString(rdr.GetOrdinal("Name")));
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //    finally
            //    {
            //        c.Close();
            //    }
            //}
    }
}
