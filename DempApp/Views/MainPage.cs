using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Controllers;
using System.Windows.Forms;

namespace DempApp.Views
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Track.Move(this,0);
            new LoginController().ViewLoginPage();                               
        }

        private void Btn_QueryData_Click(object sender, EventArgs e)
        {
            Track.Move(this,0);
            new QueryDataController().ViewQueryDataPage();
        }
    }
}
