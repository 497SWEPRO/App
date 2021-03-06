﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DempApp.Controllers;

namespace DempApp.Shared
{
    public static class Connection
    {
        private static string AzureConnection="";
        private static string DWConnection="";
        private static string DataBase = "";


        public static void SetAzureConnectionString(string ServerIP, string UserID, string Password, string DataBaseName)
        {
            string Connection;
          
                Connection = "Server=tcp:" + ServerIP + ",1433;Initial Catalog=" + DataBaseName + ";User ID=" + UserID + ";Password=" + Password 
                + ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Persist Security Info=False;Connection Timeout=30;";
            

               //  ServerIP = "migrator.database.windows.net";
               // DataBaseName = Migrator;
               // UserID = adel;
               //Password = =A12345ksu;


            AzureConnection = Connection;
            using (SqlConnection Temp = new SqlConnection(AzureConnection))
            {
                Temp.Open(); // throws exception if invalid
                Temp.Close();
            }
            

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
            using (SqlConnection Temp = new SqlConnection(DWConnection))
            {
                Temp.Open(); // throws exception if invalid
                Temp.Close();
            }
            DataBase = DataBaseName;

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
            if (System.IO.File.Exists("AzureConnection.cn"))
            { 
                System.IO.File.Delete("AzureConnection.cn");
            }
            StreamWriter File = new StreamWriter("AzureConnection.cn");
            File.WriteLine("True");
            File.Write(AzureConnection);
            File.Close();
            new AdminController().SetStage(5);
        }

        public static void DisableAzureConnection()
        {
            if (System.IO.File.Exists("AzureConnection.cn"))
            {
                System.IO.File.Delete("AzureConnection.cn");
            }
            StreamWriter File = new StreamWriter("AzureConnection.cn",true);
            File.WriteLine("False");
            File.Close();
            new AdminController().SetStage(4);
        }

        public static bool CheckPermission()
        {
            
            try
            {
                StreamReader File = new StreamReader("AzureConnection.cn");
                bool Allow = bool.Parse(File.ReadLine());
                if (Allow)
                {
                    string Connection = File.ReadLine();
                    AzureConnection = Connection;
                    File.Close();
                    return true;
                }
                else
                {
                    File.Close();
                    return false;
                }                
                
            }
            catch (Exception ex)
            {
                return false;
            }
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

        public static void ClearConnection()
        {
            AzureConnection = "";
            DWConnection = "";
        }

        public static string getDataBaseName()
        {
            return DataBase;
        }


    }
}
