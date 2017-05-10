using DempApp.Models.DAL;
using DempApp.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DempApp.Models.BLL
{
    class StorageBLL
    {
        StorageDAL SDAL = new StorageDAL();
        public bool InsertAttributes(DataTable Table,int ID)
        {            
            DataColumn DC = new DataColumn();
            DC.ColumnName = "SchemaID";
            DC.DataType = System.Type.GetType("System.Int64");
            Table.Columns.Add(DC);

            for (int i=0;i<Table.Rows.Count;i++)
            {
                Table.Rows[i]["SchemaID"] = ID;
            }

            if (SDAL.InsertAttributes(Table))
            {
                return true;
            }
            return false;
        }

        public bool StoreSchema(DataTable Table)
        {
            string Schema = Table.Rows[0]["DataBase"].ToString();
            int Schema_ID = -1;
            if (SDAL.AddSchema(Schema,ref Schema_ID))
            {
                Table.Columns.RemoveAt(0);
                if(InsertAttributes(Table, Schema_ID))
                {
                    Table.Columns.RemoveAt(5);
                    return true;
                }
                Table.Columns.RemoveAt(5);
                return false;
            }
            return false;
        }



        public bool CorrectErrors(string Schema)
        {
            return SDAL.CorrectErrors(Schema);
        }


        public int DetectErrors(string Schema)
        {
            DataTable result = SDAL.DetectErrors(Schema); ;

            return int.Parse(result.Rows[0][0].ToString());
        }

        public DataTable GetSchema(string Schema)
        {
            return SDAL.GetSchema(Schema);
        }

  }
}
