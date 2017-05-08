using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Views;
using System.Data;
using DempApp.Models.BLL;
using System.Windows.Forms;

namespace DempApp.Controllers
{
    class ExtractMetaDataController
    {
        DataWarehouseBLL DWBLL = new DataWarehouseBLL();
        StorageBLL SBLL = new StorageBLL();
        public void ViewExtractMetaData()
        {
            new ExtractMetaDataView().Show();
        }

        public DataTable ExtractMetaData()
        {

            DataTable dt;
            try
            {
                dt = DWBLL.ExtractMetaData();                
            }
            catch (Exception ex)
            {
                dt = new DataTable();
                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (SBLL.StoreSchema(dt))
            {
                MessageBox.Show("Schema successfully stored!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return dt;
            }
            else
            {
                MessageBox.Show("Could Not Store Schema!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return dt;


        }



    }
}
