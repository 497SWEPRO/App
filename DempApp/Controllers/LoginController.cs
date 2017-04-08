using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Views;

namespace DempApp.Controllers
{
    class LoginController
    {

        public void ViewLoginPage()
        {
            new Login().Show();
        }
    }
}
