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

    }
}
