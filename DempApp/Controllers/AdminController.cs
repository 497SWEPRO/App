using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DempApp.Views;
using System.IO;
using DempApp.Shared;

namespace DempApp.Controllers
{
    class AdminController
    {

        public void ViewAdminPage()
        {
            new AdminDefualt().Show();
        }

        public void SetStage(int Stage)
        {
            StreamWriter File = new StreamWriter(Connection.getDataBaseName()+".stg");
            File.Write(Connection.getDataBaseName()+Environment.NewLine+ Stage);
            File.Close();
        }

        public int GetStage()
        {
            string Db = "";
            try
            {
                StreamReader File = new StreamReader(Connection.getDataBaseName() + ".stg");
                Db = File.ReadLine();
            if (Db == Connection.getDataBaseName())
            {
                int Stage = 0;
                if(int.TryParse(File.ReadLine(),out Stage))
                {
                        File.Close();
                    return Stage;
                }else
                {
                        File.Close();
                        return Stage;
                }
            }
            return 0;
            }catch(Exception ex)
            {
                return 0;
            }            
        }
    }

}
