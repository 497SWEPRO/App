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
    class AzureDAL
    {

        public DataTable ExcuteQuery(string Query)
        {
            SqlConnection Connnection = new SqlConnection();
           Connnection.ConnectionString = Connection.GetAzureConnection();
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


        public bool ExcuteSchema(string Query)
        {
            bool flag = false;
            SqlConnection Connnection = new SqlConnection();
            Connnection.ConnectionString = Connection.GetAzureConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter db = new SqlDataAdapter();
            using (Connnection)
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = Query;
                    cmd.Connection = Connnection;
                    Connnection.Open();
                    cmd.ExecuteNonQuery();
                    db.SelectCommand = cmd;
                    flag = true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return flag;
        }



        public bool DropAllTabels()
        {
            bool flag = false;
            string Query = "while(exists (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES) ) begin declare @Drop_Query nvarchar(2000) declare @TBL_Schema nvarchar(2000) = (SELECT TOP 1 TABLE_SCHEMA FROM INFORMATION_SCHEMA.TABLES) declare @TBL_Name nvarchar(2000) = (SELECT TOP 1 TABLE_NAME FROM INFORMATION_SCHEMA.TABLES) set @Drop_Query  = 'DROP TABLE ' +  @TBL_Schema + '.[' + @TBL_Name + '];' EXEC(@Drop_Query) end";
            SqlConnection Connnection = new SqlConnection();
            Connnection.ConnectionString = Connection.GetAzureConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter db = new SqlDataAdapter();
            using (Connnection)
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = Query;
                    cmd.Connection = Connnection;
                    Connnection.Open();
                    cmd.ExecuteNonQuery();
                    db.SelectCommand = cmd;
                    flag = true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return flag;
        }
    }
}
