using DempApp.Controllers;
using DempApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DempApp.Views
{
    public partial class SetUpConnectionView : Form
    {
        /*
         *new AdminController().SetStage(5); 
         */
        public SetUpConnectionView()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Track.GoBack(this, 3);
        }

        private void SetUpConnectionView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Track.GoBack(this, 3);
        }
        
        private void PB_OnOFF_Click(object sender, EventArgs e)
        {
            bool flag = Connection.CheckPermission();
            if (flag)
            {
                Connection.DisableAzureConnection();
                SetImage();
            }
            else
            {
                Connection.SaveAzureConnection();
                SetImage();
            }


        }


        private void SetImage()
        {
            Bitmap On = DempApp.Properties.Resources.switch_on;
            Bitmap Off = DempApp.Properties.Resources.switch_off;
            bool flag = Connection.CheckPermission();
            if (flag)
            {
                PB_OnOFF.Image = On;
            }
            else
            {
                PB_OnOFF.Image = Off;
            }
        }

        private void SetUpConnectionView_Load(object sender, EventArgs e)
        {
            SetImage();
        }
    }
}
