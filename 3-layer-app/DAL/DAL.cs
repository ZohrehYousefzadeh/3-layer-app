using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace _3_layer_app.DAL
{
    class DAL
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter da;

        public DAL()
        {
            con = new SqlConnection();
            com = new SqlCommand();
            da = new SqlDataAdapter();
            com.Connection = con;
            da.SelectCommand = com;

        }

        public void Connect()
        {
            con.ConnectionString= @"Data Source=PARSIANNOTEBOOK;Initial Catalog=Software_Project;Integrated Security=True";
            con.Open();
        }

        public void DisConnect()
        {
            con.Close();
        }

        public void EXE(string SQL)
        {
            com.CommandText = SQL;
            com.ExecuteNonQuery();
        }
        
        public DataTable Select(string SQL)
        {
            com.CommandText = SQL;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
