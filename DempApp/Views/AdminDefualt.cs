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
            Track.GoBack(this,1);
        }

        private void AdminDefualt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void Btn_ExtractMetaData_Click(object sender, EventArgs e)
        {
            Track.Move(this,3);
            new ExtractMetaDataController().ViewExtractMetaData();
        }

        private void AdminDefualt_Load(object sender, EventArgs e)
        {

        }        

        private void button4_Click(object sender, EventArgs e)
        {
            new AdminController().SetStage(3);
            Stage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AdminController().SetStage(4);
            Stage();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new AdminController().SetStage(5);
            Stage();
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
                    break;

                case 1:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.Completed;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
                    break;

                case 2:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.Completed;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.Completed;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
                    break;

                case 3:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.Completed;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.Completed;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.Completed;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
                    break;

                case 4:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.Completed;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.Completed;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.Completed;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.Completed;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
                    break;

                case 5:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.Completed;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.Completed;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.Completed;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.Completed;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.Completed;
                    break;

                default:
                    Pbox_ExtractMetadata.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_CheckIncompatiblity.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_BuildOnAzure.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_MigrateData.Image = DempApp.Properties.Resources.NotCompleted;
                    Pbox_SetUpConnection.Image = DempApp.Properties.Resources.NotCompleted;
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

        private void AdminDefualt_Load_1(object sender, EventArgs e)
        {

        }
    }
}
