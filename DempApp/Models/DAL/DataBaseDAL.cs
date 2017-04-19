using DempApp.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DempApp.Models.DAL
{
    class DataBaseDAL
    {

        public DataTable GetDataBaseSchema()
        {
            SqlConnection Connnection = new SqlConnection();
            Connnection.ConnectionString = Connection.GetDWConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter db = new SqlDataAdapter();
            DataTable dt = new DataTable();
            using (Connnection)
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT TABLE_CATALOG,TABLE_NAME,COLUMN_NAME,DATA_TYPE,IS_NULLABLE,ORDINAL_POSITION  FROM INFORMATION_SCHEMA.COLUMNS ORDER BY TABLE_CATALOG";
                    cmd.Connection = Connnection;
                    Connnection.Open();
                    cmd.ExecuteScalar();
                    db.SelectCommand = cmd;
                    db.Fill(dt);
                }
                catch (Exception ex)
                {
                }
                return dt;
            }
        }

    }
}
