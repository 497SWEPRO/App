using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Models.DAL;

namespace DempApp.Models.BLL
{
    class UserBLL
    {
        UsersDAL userDAL = new UsersDAL();
        public DataTable GetUserByID()
        {
            return userDAL.GetUserByID();
        }

        
        public DataTable QueryData(string Query)
        {
            return userDAL.QueryData(Query);
        }

    }
}
