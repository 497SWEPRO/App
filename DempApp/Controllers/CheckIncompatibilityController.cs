using DempApp.Models.BLL;
using DempApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DempApp.Controllers
{
    class CheckIncompatibilityController
    {
        StorageBLL SBLL = new StorageBLL();
        public void CheckIncompatibilityPage()
        {
            new CheckIncompatibilityView().Show();
        }

        public int DetectErrors(string Scheam)
        {
            int Errors = SBLL.DetectErrors(Scheam);
            if (Errors == 0)
            {
                new AdminController().SetStage(2);
                return Errors;
            }
            return Errors;
        }

        public void CorrectErrors(string Scheam)
        {
            try
            {
                if (SBLL.CorrectErrors(Scheam))
                {
                    MessageBox.Show("Schema successfully Corrected!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new AdminController().SetStage(2);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                    
        }



    }
}
