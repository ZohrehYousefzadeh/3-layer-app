using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace _3_layer_app.BL
{
    class BL
    {
        DAL.DAL dal = new DAL.DAL();
        public string Project_Num;
        public string Auto_ID;
        public string Auto_Date;
        public string Addr;

        public void ADD()
        {
            dal.Connect();
            string sql = "Insert into Mojavez(Project_Num,Auto_ID,Auto_Date,Addr)";
            sql += " Values('{0}','{1}','{2}','{3}')";
            sql = string.Format(sql, this.Project_Num, this.Auto_ID, this.Auto_Date, this.Addr);
            dal.EXE(sql);
            dal.DisConnect();
        }

        public DataTable SHOWDATA()
        {
            dal.Connect();
            DataTable dt = dal.Select("Select * from Mojavez");
            dal.DisConnect();
            return dt;
        }
    }
}
