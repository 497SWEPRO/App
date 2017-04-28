using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Views;
using DempApp.Shared;
using System.Windows.Forms;
using System.Data;
using DempApp.Models.BLL;

namespace DempApp.Controllers
{
    class QueryDataController
    {
        AzureBLL AzBLL = new AzureBLL();
        public void ViewQueryDataPage()
        {
            if (Connection.CheckAzureConnectionState())
            {
                new QueryData().Show();
            }
            else
            {
                MessageBox.Show("No Connection Established", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Track.GoBack(null, 0);
            }
            
        }

        public DataTable QueryData(string Query)
        {
            DataTable dt;
            try
            {
                dt = AzBLL.ExcuteQuery(Query);
            }
            catch (Exception ex)
            {
                dt = new DataTable();
                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }



    }
}
