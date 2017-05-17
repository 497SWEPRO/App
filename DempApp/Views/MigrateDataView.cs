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
    public partial class MigrateDataView : Form
    {
        public MigrateDataView()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Track.GoBack(this, 3);
        }

        private void MigrateDataView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Track.GoBack(this, 3);
        }
    }
}
