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
    public partial class Login : Form
    {
        /*
         case 1 : Legacy & Local
         Case 2 : Legacy & Online
         Case 3 : Azure & Online
             */
        private int Case;
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Track.GoBack(this, 0);
        }


        private void ControlInputs(int Case)
        {
            if (Case == 1)
            {
                txt_Server.Text = "";
                txt_Username.Text = "";
                txt_Password.Text = "";

                txt_Server.Enabled = false;
                txt_Username.Enabled = false;
                txt_Password.Enabled = false;
            }else if (Case == 2)
            {
                txt_Server.Enabled = true;
                txt_Server.Text = "";
                txt_Username.Enabled = true;
                txt_Password.Enabled = true;
                RB_Local.Enabled = true;

            }else if (Case == 3)
            {
                RB_Local.Checked = false;
                RB_Local.Enabled = false;
                RB_Online.Checked = true;
                txt_Server.Text = "";
                txt_Server.Text = ".database.windows.net";
                txt_Server.Enabled = true;
                txt_Username.Enabled = true;
                txt_Password.Enabled = true;

            }
            else
            {

            }
        }

        private bool CheckValidation()
        {
            if (Case == 1)
            {
                if (txt_DBName.Text == "")
                {
                    return false;
                }
            }
            else if (Case == 2)
            {
                if (txt_Server.Text == "" || txt_Username.Text =="" || txt_Password.Text=="" || txt_DBName.Text == "")
                {
                    return false;
                }
            }
            else if (Case == 3)
            {
                if (txt_Server.Text == "" || txt_Username.Text == "" || txt_Password.Text == "" || txt_DBName.Text == "")
                {
                    return false;
                }
            }
            else
            {
                 return false;
            } 

            return true;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
            {
                MessageBox.Show("Please Fill your credential!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {

                try {
                    new LoginController().SetConnection(txt_Server.Text,txt_Username.Text, txt_Password.Text, txt_DBName.Text, Case);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Track.Move(this, 1);
                new AdminController().ViewAdminPage();
            }
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RB_Legacy_CheckedChanged(object sender, EventArgs e)
        {
            ControlInputs(2);
        }

        private void RB_Azure_CheckedChanged(object sender, EventArgs e)
        {
            ControlInputs(3);
        }

        private void RB_Local_CheckedChanged(object sender, EventArgs e)
        {
            ControlInputs(1);
        }

        private void RB_Online_CheckedChanged(object sender, EventArgs e)
        {
            ControlInputs(2);
        }
    }
}
 