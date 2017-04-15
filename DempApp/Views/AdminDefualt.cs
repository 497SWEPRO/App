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
            Application.Exit();
        }
    }
}
