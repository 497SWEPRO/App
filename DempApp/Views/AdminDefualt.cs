using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DempApp.Controllers;
using DempApp.Shared;

namespace DempApp.Views
{
    public partial class AdminDefualt : Form
    {
        public AdminDefualt()
        {
            InitializeComponent();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            Connection.ClearConnection();
            Track.GoBack(this,1);
        }

        private void AdminDefualt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void Btn_ExtractMetaData_Click(object sender, EventArgs e)
        {            
            if (CheckDataWareHouseLogin())
            {
                Track.Move(this, 3);
                new ExtractMetaDataController().ViewExtractMetaData();
            }
        }   

        private void Btn_BuildOnAzure_Click(object sender, EventArgs e)
        {
            if (CheckAzureLogin())
            {
                Track.Move(this, 3);
                new ExcuteSchemaController().ViewLoginPage();
            }         
            
        }        

 


        public void Stage()
        {
            int Stage = new AdminController().GetStage();
            switch (Stage)
            {
                case 0:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
                    Btn_CheckIncompatibility.Enabled = false;
                    Btn_BuildOnAzure.Enabled = false;
                    Btn_MigrateData.Enabled = false;
                    Btn_SetUp.Enabled = false;
                    break;

                case 1:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.Completed;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
                    Btn_CheckIncompatibility.Enabled = true;
                    Btn_BuildOnAzure.Enabled = false;
                    Btn_MigrateData.Enabled = false;
                    Btn_SetUp.Enabled = false;
                    break;

                case 2:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.Completed;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.Completed;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
                    Btn_CheckIncompatibility.Enabled = true;
                    Btn_BuildOnAzure.Enabled = true;
                    Btn_MigrateData.Enabled = false;
                    Btn_SetUp.Enabled = false;
                    break;

                case 3:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.Completed;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.Completed;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.Completed;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
                    Btn_CheckIncompatibility.Enabled = true;
                    Btn_BuildOnAzure.Enabled = true;
                    Btn_MigrateData.Enabled = true;
                    Btn_SetUp.Enabled = false;
                    break;

                case 4:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.Completed;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.Completed;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.Completed;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.Completed;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
                    Btn_CheckIncompatibility.Enabled = true;
                    Btn_BuildOnAzure.Enabled = true;
                    Btn_MigrateData.Enabled = true;
                    Btn_SetUp.Enabled = true;
                    break;

                case 5:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.Completed;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.Completed;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.Completed;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.Completed;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.Completed;
                    Btn_CheckIncompatibility.Enabled = true;
                    Btn_BuildOnAzure.Enabled = true;
                    Btn_MigrateData.Enabled = true;
                    Btn_MigrateData.Enabled = true;
                    break;

                default:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
                    Btn_CheckIncompatibility.Enabled = false;
                    Btn_BuildOnAzure.Enabled = false;
                    Btn_MigrateData.Enabled = false;
                    Btn_SetUp.Enabled = false;
                    break;
            }
        }

        private void AdminDefualt_Shown(object sender, EventArgs e)
        {
            Stage();
        }

        private void Btn_CheckIncompatibility_Click(object sender, EventArgs e)
        {
            Track.Move(this, 3);
            new CheckIncompatibilityController().CheckIncompatibilityPage();
        }

        private void Btn_MigrateData_Click(object sender, EventArgs e)
        {
            if (CheckAzureLogin())
            {
                Track.Move(this, 3);
                new MigrateDataController().ViewMigrateDataPage();
            }           
        }


        private bool CheckAzureLogin()
        {
            if (Connection.CheckAzureConnectionState())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please Login To your Azure Account!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Track.Move(this, 3);
                new LoginController().ViewLoginPage();
                return false;
            }

        }


        private bool CheckDataWareHouseLogin()
        {
            if (Connection.CheckDWConnectionState())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please Login To your Data warehouse server!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Track.Move(this, 3);
                new LoginController().ViewLoginPage();
                return false;
            }

        }

        private void Btn_SetUp_Click(object sender, EventArgs e)
        {
            if (CheckAzureLogin())
            {
                Track.Move(this, 3);
                new AdminController().ViewSetupConnectionPage();
            }
        }
    }
}
