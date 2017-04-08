using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Views;
using System.Windows.Forms;


namespace DempApp.Controllers
{
    class MainController
    {

       public void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());            
        }

        public void ViewMainPage()
        {
            new MainPage().Show();
        }

    }
}
