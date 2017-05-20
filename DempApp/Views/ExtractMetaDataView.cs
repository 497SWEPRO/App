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
    public partial class ExtractMetaDataView : Form
    {
        public ExtractMetaDataView()
        {
            InitializeComponent();
        }

        private void Btn_Extract_Click(object sender, EventArgs e)
        {
            PBar1.Value = 0;
            PBar1.Value += 30;
            DataTable Result;
            PBar1.Value += 30;
            Result = new ExtractMetaDataController().ExtractMetaData();
            PBar1.Value += 30;
            DGV_Result.DataSource = Result;
            PBar1.Value += 10;
        }

        private void ExtractMetaDataView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Track.GoBack(this, 3);
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Track.GoBack(this, 3);
        }

        private void ExtractMetaDataView_Load(object sender, EventArgs e)
        {

        }
    }
}
