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
    class DataWarehouseDAL
    {
        public DataTable GetDataWareHouseSchema()
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
                    cmd.CommandText = "SELECT TABLE_CATALOG as 'DataBase',TABLE_NAME as 'Table',COLUMN_NAME as 'Attribute',DATA_TYPE as 'Data Type',IS_NULLABLE as 'Is Nullable',ORDINAL_POSITION as 'Position'  FROM INFORMATION_SCHEMA.COLUMNS ORDER BY TABLE_CATALOG";
                    cmd.Connection = Connnection;
                    Connnection.Open();
                    cmd.ExecuteScalar();
                    db.SelectCommand = cmd;
                    db.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return dt;
            }
        }

        public DataTable ExcuteQuery(string Query)
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
                    cmd.CommandText = Query;
                    cmd.Connection = Connnection;
                    Connnection.Open();
                    cmd.ExecuteScalar();
                    db.SelectCommand = cmd;
                    db.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return dt;
            }
        }
    }
}
