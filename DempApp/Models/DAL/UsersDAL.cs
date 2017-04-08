using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Shared;

namespace DempApp.Models.DAL
{
    class UsersDAL
    {

        public DataTable GetUserByID()
        {
            SqlConnection Connnection = Connection.GetDWConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter db = new SqlDataAdapter();
            DataTable dt = new DataTable();
            using (Connnection)
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetAllUser";
                    //cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
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
