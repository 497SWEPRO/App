using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DempApp.Shared
{
    static class Connection
    {
        private static SqlConnection AzureConnection = new SqlConnection();
        private static SqlConnection DWConnection = new SqlConnection();
        private static bool AzureFlag = false;
        private static bool DWFlag = false;

        public static void SetAzureConnectionString(string ServerIP,string UserID,string Password,string DataBaseName)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                
            builder.DataSource = ServerIP;  //"your_server.database.windows.net";
            builder.UserID = UserID;
            builder.Password = Password;
            builder.InitialCatalog = DataBaseName;
            AzureConnection.ConnectionString = builder.ConnectionString;
            AzureFlag = true;
        }

        public static SqlConnection GetAzureConnection()
        {
            if(AzureFlag == true)
            {
                return AzureConnection;
            }
            else
            {
                return null;
            }
        }

        public static void SetDWConnectionString(string ServerIP, string UserID, string Password, string DataBaseName)
        {
            string Connection;

            if (ServerIP == "" && UserID== ""&& Password=="")
            {
                Connection = "data source=localhost;   initial catalog=" + DataBaseName + "; persist security info=True;     Integrated Security=SSPI;";
            }

            else
            {
                Connection = "Data Source=" + ServerIP + ";Initial Catalog=" + DataBaseName + ";User Id=" + UserID + ";Password=" + Password;
            }
            
             

            DWConnection.ConnectionString = Connection;
            DWFlag = true;
        }

        public static SqlConnection GetDWConnection()
        {
            if (DWFlag == true)
            {
                return DWConnection;
            }
            else
            {
                return null;
            }
        }
    }
}
