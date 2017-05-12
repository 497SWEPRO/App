using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Models.DAL;
using System.Data;

namespace DempApp.Models.BLL
{
    class AzureBLL
    {
        AzureDAL AzureDAL = new AzureDAL();

        public DataTable ExcuteQuery(string Query)
        {
            DataTable dt;
            try
            {
                dt = AzureDAL.ExcuteQuery(Query);
            }
            catch (Exception ex)
            {
                dt = new DataTable();
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public bool ExcuteSchema(string Schema)
        {
            return AzureDAL.ExcuteSchema(Schema);
        }
    }
}
