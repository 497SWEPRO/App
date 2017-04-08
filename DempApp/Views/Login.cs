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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Track.GoBack(this,0);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Track.Move(this,1);
            new AdminController().ViewAdminPage();
        }
    }
}
 