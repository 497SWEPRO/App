using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DempApp.Shared
{
    public static class Connection
    {
        private static string AzureConnection="";
        private static string DWConnection="";


        public static void SetAzureConnectionString(string ServerIP, string UserID, string Password, string DataBaseName)
        {
            string Connection;

            if (ServerIP == "" && UserID == "" && Password == "")
            {
                Connection = "data source=localhost;   initial catalog=" + DataBaseName + "; persist security info=True;     Integrated Security=SSPI;";
            }

            else
            {
                Connection = "Data Source=" + ServerIP + ";Initial Catalog=" + DataBaseName + ";User Id=" + UserID + ";Password=" + Password;
                Connection = "Server=tcp:migrator.database.windows.net,1433;Initial Catalog=Migrator;Persist Security Info=False;User ID=adel;Password=A12345ksu;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            }



            AzureConnection = Connection;

        }
        public static void SetDWConnectionString(string ServerIP, string UserID, string Password, string DataBaseName)
        {
            string Connection;

            if (ServerIP == "" && UserID == "" && Password == "")
            {
                Connection = "data source=localhost;   initial catalog=" + DataBaseName + "; persist security info=True;     Integrated Security=SSPI;";
            }

            else
            {
                 Connection = "Data Source=" + ServerIP + ";Initial Catalog=" + DataBaseName + ";User Id=" + UserID + ";Password=" + Password;                 
            }



            DWConnection = Connection;

        }

        public static string GetDWConnection()
        {

            return DWConnection;

        }

        public static string GetAzureConnection()
        {

            return AzureConnection;

        }

        public static void SaveDWConnection()
        {
            StreamWriter File = new StreamWriter("DWConnection.cn");
            File.Write(DWConnection);
            File.Close();
        }


        public static void SaveAzureConnection()
        {
            StreamWriter File = new StreamWriter("AzureConnection.cn");
            File.Write(AzureConnection);
            File.Close();
        }


        public static bool CheckDWConnectionState()
        {
            if (DWConnection == "")
            {
                return false;
            } else
            {
                return true;
            }
        }

        public static bool CheckAzureConnectionState()
        {
            if (AzureConnection == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
