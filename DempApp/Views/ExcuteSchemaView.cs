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
            Track.GoBack(this, 3);
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
                if(new ExcuteSchemaController().ExcuteSchema())
                {
                    t.Abort();
                    MessageBox.Show("Schema Successfully built on Azure", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new AdminController().SetStage(3);
                }

            }
            catch (Exception ex)
            {
                t.Abort();
                this.Enabled = true;
                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            t.Abort();
            this.Enabled = true;
            PBar1.Value += 50;
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(test));
            t.Start();
            try
            {
                this.Enabled = false;
                new ExcuteSchemaController().Reset();
            }
            catch (Exception ex)
            {
                t.Abort();
                this.Enabled = true;
                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            t.Abort();
            this.Enabled = true;
            MessageBox.Show("All Data have been erased!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PBar1.Value = 0;

        }
    }
}
