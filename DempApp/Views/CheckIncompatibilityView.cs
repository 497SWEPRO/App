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
    public partial class CheckIncompatibilityView : Form
    {
        CheckIncompatibilityController CM = new CheckIncompatibilityController();
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
            int Errors = CM.DetectErrors(Connection.getDataBaseName());
            if (Errors > 0)
            {

                lbl_BadMessageNumber.Text = Errors.ToString();
                Lbl_GoodMessage.Visible = false;
                lbl_BadMessage.Visible = true;
                lbl_BadMessageNumber.Visible = true;
                Btn_Correct.Enabled = true;
            }else
            {
                lbl_BadMessage.Visible = false;
                lbl_BadMessageNumber.Visible = false;
                Lbl_GoodMessage.Visible = true;

            }
            
            
        }

        private void Btn_Correct_Click(object sender, EventArgs e)
        {
            CM.CorrectErrors(Connection.getDataBaseName());                                    
        }
    }
}
