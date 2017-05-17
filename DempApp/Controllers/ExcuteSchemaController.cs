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
        AzureBLL ABLL = new AzureBLL();
        StorageBLL SBLL = new StorageBLL();
        public void ViewLoginPage()
        {
            new ExcuteSchemaView().Show();
        }

        public void ExcuteSchema()
        {
            string Create_Query="";
            DataTable Schema = SBLL.GetSchema(Connection.getDataBaseName());
            for (int i=0;i<Schema.Rows.Count;i++)
            {
                Create_Query += "CREATE TABLE";
                string Table = Schema.Rows[i]["Org_Table"].ToString();
                Create_Query += " " + Table;
                Create_Query += "(";
                Create_Query += Environment.NewLine;
                while (i < Schema.Rows.Count && Schema.Rows[i]["Org_Table"].ToString() == Table)
                {
                    Create_Query += Schema.Rows[i]["Attribute"].ToString();
                    Create_Query += " " + Schema.Rows[i]["DataType"].ToString();
                    if (Schema.Rows[i]["Is_Nullable"].ToString() == "NO")
                    {
                        Create_Query += " " + "NOT NULL";
                    }
                    else
                    {
                        Create_Query += " " + "NULL";
                    }
                    i++;
                    if (i < Schema.Rows.Count)
                    {
                        if (Schema.Rows[i]["Org_Table"].ToString() == Table)
                        {
                            Create_Query += ",";
                        }
                    }
                   
                    Create_Query += Environment.NewLine;

                }
                i--;
                Create_Query += ");";
                Create_Query += Environment.NewLine + Environment.NewLine;
            }
            try
            {
                if (ABLL.ExcuteSchema(Create_Query))
                {
                    MessageBox.Show("Schema Successfully built on Azure", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new AdminController().SetStage(3);
                    return;
                }
            }
            catch (Exception ex)
            {               
                throw new Exception(ex.Message);
            }
            
        }

        public void Reset()
        {
            try
            {
                ABLL.DropAllTabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("All Data have been erased!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
