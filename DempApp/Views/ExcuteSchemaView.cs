using DempApp.Controllers;
using DempApp.Shared;
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
    public partial class ExcuteSchemaView : Form
    {
        public ExcuteSchemaView()
        {
            InitializeComponent();
        }

        private void ExcuteSchemaView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Track.GoBack(this, 3);
        }

        private void ExcuteSchemaView_Load(object sender, EventArgs e)
        {
            lbl_SchemaName.Text = Connection.getDataBaseName();
        }
        public void test()
        {
            Application.Run(new Loading());
        }

        private void Btn_Excute_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(test));
            PBar1.Value = 0;
            PBar1.Value = 50;
            t.Start();
            try {
                this.Enabled = false;
                new ExcuteSchemaController().ExcuteSchema();

            }
            catch (Exception ex)
            {
                t.Abort();
                this.Enabled = true;
                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            t.Abort();
            this.Enabled = true;
            PBar1.Value = 50;
        }
    }
}
