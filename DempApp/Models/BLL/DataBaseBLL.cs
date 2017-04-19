using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Models.DAL;

namespace DempApp.Models.BLL
{
    class DataBaseBLL
    {
        DataBaseDAL DBDAL = new DataBaseDAL();
        public DataTable GetDataBaseSchema()
        {
            return DBDAL.GetDataBaseSchema();
        }

  }
}
