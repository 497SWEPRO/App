﻿using System;
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
        public QueryData()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Track.GoBack(this,0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.SetDWConnectionString("", "", "", "TestDB");
            UserBLL userBLL = new UserBLL();
            DataTable dt = userBLL.GetUserByID();
            dataGridView1.DataSource = dt;
        }
    }
}
