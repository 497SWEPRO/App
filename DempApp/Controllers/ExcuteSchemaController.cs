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
    class ExcuteSchemaController
    {
        StorageBLL SBLL = new StorageBLL();
        public void ViewLoginPage()
        {
            new ExcuteSchemaView().Show();
        }

        public void ExcuteSchema()
        {

            DataTable Schema = SBLL.GetSchema(Connection.getDataBaseName());
            for (int i=0;i<Schema.Rows.Count;i++)
            {
                string Create_Query = "CREATE TABLE";
                Create_Query += " " + Schema.Rows[0]["Org_Table"].ToString();
                Create_Query += "(";
                Create_Query += Environment.NewLine;
                Create_Query += Schema.Rows[i]["Attribute"].ToString();
                Create_Query += " " + Schema.Rows[i]["DataType"].ToString();
                if (Schema.Rows[i]["Is_Nullable"].ToString() == "NO")
                {
                    Create_Query += " " + "NOT NULL";
                }else
                {
                    Create_Query += " " + "NULL";
                }
                if (!(i == (Schema.Rows.Count - 1)))
                {
                    Create_Query += ",";
                }
                Create_Query += Environment.NewLine;
                Create_Query += ");";
            }
            
        }
    }
}
