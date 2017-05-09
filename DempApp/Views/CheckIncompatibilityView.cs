using DempApp.Controllers;
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
    public partial class CheckIncompatibilityView : Form
    {
        public CheckIncompatibilityView()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Track.GoBack(this, 3);
        }

        private void Btn_Detect_Click(object sender, EventArgs e)
        {
            Btn_Correct.Enabled = true;
            new AdminController().SetStage(2);
        }
    }
}
