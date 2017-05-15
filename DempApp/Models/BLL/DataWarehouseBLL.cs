using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Models.DAL;
using System.Data;

namespace DempApp.Models.BLL
{
    class DataWarehouseBLL
    {
        DataWarehouseDAL DWDAL = new DataWarehouseDAL();


        public DataTable ExtractMetaData()
        {
            return DWDAL.GetDataWareHouseSchema();
        }

        public DataTable ExcuteQuery(string Query)
        {
            return DWDAL.ExcuteQuery(Query);
        }

    }
}
