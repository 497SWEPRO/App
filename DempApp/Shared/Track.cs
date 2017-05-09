using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DempApp.Controllers
{
    public static class Track
    {
        // Level 0 , Main Page
        // Level 1 , Secound Level Pages
        // Level n , Level n Pages

        private static Form[] Back = new Form[5];

        private static void SetBack(Form Value,int Level)
        {
            Back[Level] = Value;
        }
        
        public static void GoBack(Form Caller,int Level)
        {
            if (Caller == null)
            {
                Back[Level].Show();
            }else if (Level == 3)
            {
                Caller.Hide();
                new AdminController().ViewAdminPage();
            }
            else
            {
                Caller.Hide();
                Back[Level].Show();
            }
           
        }
        
        public static void Move(Form Caller,int Level)
        {
            Caller.Hide();
            Track.SetBack(Caller,Level);
        }           
    }
}
