using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DempApp.Models.DAL
{
    class StorageDAL
    {

        public bool InsertAttributes(DataTable Table)
        {
            bool flag = false;
            SqlConnection Connnection = new SqlConnection();
            Connnection.ConnectionString = ConfigurationManager.ConnectionStrings["StorageConnection"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter db = new SqlDataAdapter();
            using (Connnection)
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertAttrbutes";
                    cmd.Parameters.Add(new SqlParameter("@AttubutesType", Table));
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


        public bool AddSchema(string Schema, ref int Schema_ID)
        {
            bool flag = false;
            SqlConnection Connnection = new SqlConnection();
            Connnection.ConnectionString = ConfigurationManager.ConnectionStrings["StorageConnection"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter db = new SqlDataAdapter();
            using (Connnection)
            {
                try
                {
                    Schema_ID = -1;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AddSechema";
                    cmd.Parameters.Add(new SqlParameter("@Schema", Schema));
                    SqlParameter outParam = new SqlParameter("@Schema_ID", SqlDbType.Int);
                    outParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outParam);
                    cmd.Connection = Connnection;
                    Connnection.Open();
                    cmd.ExecuteNonQuery();
                    Schema_ID = int.Parse(outParam.Value.ToString());
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
