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
using DempApp.Models;
using DempApp.Shared;
using DempApp.Models.BLL;
using System.Threading;

namespace DempApp.Views
{
    public partial class QueryData : Form
    {

        public QueryData()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Track.GoBack(this,0);
        }

        private void QueryData_Load(object sender, EventArgs e)
        {

        }

        private void QueryData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void test()
        {
            Application.Run(new Loading());
        }
        private void Btn_Excute_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(test));
            string Query = txt_Query.Text;
            DataTable Result;
            if (Query == "")
            {
                MessageBox.Show("Please Enter Query","Warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else
            {
                t.Start();
                try
                {
                this.Enabled = false;
                Result = new QueryDataController().QueryData(Query);
                DGV_Result.DataSource = Result;
                }catch(Exception ex)
                {
                    t.Abort();
                    this.Enabled = true;
                    MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                t.Abort();
                this.Enabled = true;
            }
        }
    }
}
