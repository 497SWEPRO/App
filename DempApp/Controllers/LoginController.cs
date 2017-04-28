using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Views;
using DempApp.Shared;

namespace DempApp.Controllers
{
    class LoginController
    {
        /*
         case 1 : Legacy & Local
         Case 2 : Legacy & Online
         Case 3 : Azure & Online
             */
        public void ViewLoginPage()
        {
            new Login().Show();
        }
        
        public void SetConnection(string Server,string UserName,string Password,string DBname,int Case)
        {
            if (Case == 1 || Case == 2)
            {
                Connection.SetDWConnectionString(Server, UserName, Password, DBname);
            }
            else
            {
                Connection.SetAzureConnectionString(Server, UserName, Password, DBname);
            }
        }
    }
}
