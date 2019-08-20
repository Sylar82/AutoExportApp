using System;

namespace AutoExportApp
{
    class Program
    {
        static void Main()
        {
            InitLogFile init = new InitLogFile();
            init.CreateDirectory();
            init.CreateLogFile();
            
            
           // UploadDataBase udb = new UploadDataBase();
            //udb.UploadItems();
            
            ExportItemsInFile exportItemsInFile = new ExportItemsInFile();
            exportItemsInFile.SelectItems();
        }
    }
}
