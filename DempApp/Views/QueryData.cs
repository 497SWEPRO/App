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

namespace DempApp.Views
{
    public partial class QueryData : Form
    {
        UserBLL userBLL = new UserBLL();
        DataBaseBLL dbBLL = new DataBaseBLL();
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

        private void Btn_Excute_Click(object sender, EventArgs e)
        {
            string Query = txt_Query.Text;
            DataTable Result;
            if (Query == "")
            {
                MessageBox.Show("Please Enter Query","Warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else
            {
                Result= new QueryDataController().QueryData(Query);
                DGV_Result.DataSource = Result;
            }
        }
    }
}
