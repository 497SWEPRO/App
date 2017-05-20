using DempApp.Models.BLL;
using DempApp.Shared;
using DempApp.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace DempApp.Controllers
{
    class MigrateDataController
    {
        StorageBLL SBLL = new StorageBLL();
        DataWarehouseBLL DBLL = new DataWarehouseBLL();
        AzureBLL ABLL = new AzureBLL();
        DataTable Schema = new DataTable();
        DataTable Data = new DataTable();

        public void ViewMigrateDataPage()
        {
            new MigrateDataView().Show();
        }

        public DataTable ExtractData(string Attributes,string Table)
        {
            string SELECT_Query;
            SELECT_Query = "SELECT " + Attributes + " From "+ Table;
            return DBLL.ExcuteQuery(SELECT_Query);
        }







        public void MigrateData()
        {
            
            string Attributes = "";
            DataTable Schema = SBLL.GetSchema(Connection.getDataBaseName());
            for (int i = 0; i < Schema.Rows.Count; i++)
            {

                string Table = Schema.Rows[i]["Org_Table"].ToString();
                while (i < Schema.Rows.Count && Schema.Rows[i]["Org_Table"].ToString() == Table)
                {
                    Attributes += Schema.Rows[i]["Attribute"].ToString();
                    i++;

                    if (i < Schema.Rows.Count)
                    {
                        if (Schema.Rows[i]["Org_Table"].ToString() == Table)
                        {
                            Attributes += ",";
                        }
                    }

                }
                i--;
                DataTable Data = ExtractData(Attributes, Table);
                if (Data.Rows.Count > 0)
                {
                    if (CompressData(Data, Table))
                    {
                        UploadData(Data, Attributes, Table);
                        Attributes = "";
                    }

                }
            }
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Compression\";
            DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
            Compress(directorySelected, directoryPath);
        }


        public static void Compress(DirectoryInfo directorySelected, string directoryPath)
        {
            if (Directory.Exists(directoryPath + @"Compressed\"))
            {
                Console.WriteLine("That path exists already.");
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(directoryPath + @"Compressed\");
            }
            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
            {
                using (FileStream originalFileStream = fileToCompress.OpenRead())
                {
                    if ((File.GetAttributes(fileToCompress.FullName) &
                       FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                    {
                        string name = fileToCompress.Directory+ @"\Compressed\" + fileToCompress.Name + ".gz";
                        using (FileStream compressedFileStream = File.Create(name))
                        {
                            using (GZipStream compressionStream = new GZipStream(compressedFileStream,
                               CompressionMode.Compress))
                            {
                                originalFileStream.CopyTo(compressionStream);

                            }
                        }
                        
                        FileInfo info = new FileInfo(directoryPath + @"Compressed\" + fileToCompress.Name + ".gz");
                        Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
                        fileToCompress.Name, fileToCompress.Length.ToString(), info.Length.ToString());
                    }

                }
            }
        }


        public bool CompressData(DataTable Data,string Table)
        {
            try
            {
                string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"\Compression\";
                if (Directory.Exists(directoryPath))
                {
                    Console.WriteLine("That path exists already.");
                }else
                {
                    DirectoryInfo di = Directory.CreateDirectory(directoryPath);
                }


                string FilePath = directoryPath + Table;
                StreamWriter File = new StreamWriter(FilePath);
                foreach (DataRow row in Data.Rows)
                {
                    bool firstCol = true;
                    foreach (DataColumn col in Data.Columns)
                    {
                        if (!firstCol) File.Write(", ");
                        File.Write(row[col].ToString());
                        firstCol = false;
                    }
                    File.WriteLine();
                }
                File.Close();                               
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }



        public void UploadData(DataTable Data,string Attributes,string Table)
        {
            string INSERT_Query="";           
            for (int i=0;i< Data.Rows.Count;i++)
            {
                INSERT_Query = "INSERT INTO " + Table + " (" + Attributes + ") " + "VALUES ";
                INSERT_Query += "(";
                
                for (int g=0;g<Data.Columns.Count;g++)
                {
                    int Test = -1;
                    if (int.TryParse(Data.Rows[i][g].ToString(), out Test))
                    {
                        INSERT_Query += Data.Rows[i][g].ToString();
                    }
                    else
                    {
                        INSERT_Query += "'"+Data.Rows[i][g].ToString() + "'";
                    }
                    if (g != (Data.Columns.Count-1))
                    {
                        INSERT_Query += ",";
                    }
                }
                INSERT_Query += ")";            
            try
            {
                ABLL.ExcuteNonQuery(INSERT_Query);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            }
        }

    }
}
