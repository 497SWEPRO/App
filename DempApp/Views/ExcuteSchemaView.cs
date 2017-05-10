using DempApp.Controllers;
using DempApp.Shared;
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
    }
}
