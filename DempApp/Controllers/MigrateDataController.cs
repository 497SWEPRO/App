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


        public void MigrateData()
        {
            try {
                Schema = SBLL.GetSchema(Connection.getDataBaseName());
                if (ExtractData(""))
                {
                    if (CompressData())
                    {
                        if (UploadData())
                        {

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool ExtractData(string Select_Query)
        {
          //  string Select_Query = "";
            Data = DBLL.ExcuteQuery(Select_Query);
            return true;           
        }

        public bool CompressData()
        {
            return true;
        }

        public bool UploadData()
        {
            return true;
        }

    }
}
