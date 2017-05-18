using DempApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void test()
        {
            Application.Run(new Loading());
        }

        private void Btn_Migrate_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(test));
            PBar1.Value = 0;
            PBar1.Value = 50;
            t.Start();
            try
            {
                this.Enabled = false;
                new MigrateDataController().MigrateData();
                t.Abort();
                MessageBox.Show("Data Successfully Migrated to Azure", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new AdminController().SetStage(4);

            }
            catch(Exception ex)
            {
                t.Abort();
                this.Enabled = true;
                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
