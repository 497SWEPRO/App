using DempApp.Models.BLL;
using DempApp.Shared;
using DempApp.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DempApp.Controllers
{
    class MigrateDataController
    {
        StorageBLL SBLL = new StorageBLL();
        DataWarehouseBLL DBLL = new DataWarehouseBLL();
        AzureBLL ABLL = new AzureBLL();
        DataTable Schema = new DataTable();
        DataTable Data = new DataTable();

        public void ViewMigrateDataPage()
        {
            new MigrateDataView().Show();
        }

        public DataTable ExtractData(string Attributes,string Table)
        {
            string SELECT_Query;
            SELECT_Query = "SELECT " + Attributes + " From "+ Table;
            return DBLL.ExcuteQuery(SELECT_Query);
        }







        public void MigrateData()
        {
            
            string Attributes = "";
            DataTable Schema = SBLL.GetSchema(Connection.getDataBaseName());
            for (int i = 0; i < Schema.Rows.Count; i++)
            {

                string Table = Schema.Rows[i]["Org_Table"].ToString();
                while (i < Schema.Rows.Count && Schema.Rows[i]["Org_Table"].ToString() == Table)
                {
                    Attributes += Schema.Rows[i]["Attribute"].ToString();
                    i++;

                    if (i < Schema.Rows.Count)
                    {
                        if (Schema.Rows[i]["Org_Table"].ToString() == Table)
                        {
                            Attributes += ",";
                        }
                    }

                }
                i--;
                DataTable Data = ExtractData(Attributes, Table);
                if (Data.Rows.Count > 0)
                {
                    if (CompressData(Data))
                    {
                        UploadData(Data, Attributes, Table);
                    }

                }
            }
        }

        public bool CompressData(DataTable Data)
        {
            return true;
        }

        public void UploadData(DataTable Data,string Attributes,string Table)
        {
            string INSERT_Query="";
            INSERT_Query = "INSERT INTO " + Table + " ("+ Attributes+") " + "VALUES ";

            for (int i=0;i< Data.Rows.Count;i++)
            {
                if(i == 0)
                {
                    INSERT_Query += "(";
                }
                else
                {
                    INSERT_Query += ",(";
                }
                
                for (int g=0;g<Data.Columns.Count;g++)
                {
                    int Test = -1;
                    if (int.TryParse(Data.Rows[i][g].ToString(), out Test))
                    {
                        INSERT_Query += Data.Rows[i][g].ToString();
                    }
                    else
                    {
                        INSERT_Query += "'"+Data.Rows[i][i].ToString() + "'";
                    }
                    if (g != (Data.Columns.Count-1))
                    {
                        INSERT_Query += ",";
                    }
                }
                INSERT_Query += ")";
            }

            try
            {
                ABLL.ExcuteQuery(INSERT_Query);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
