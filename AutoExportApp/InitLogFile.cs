using System;
using System.IO;
using static System.IO.File;

namespace AutoExportApp
{
    public class InitLogFile
    {

        private static readonly string DirectoryPath = "../logs";
        private static readonly string FilePath = "../logs/log.txt";
        readonly FileInfo fileInf = new FileInfo(FilePath);
        //  readonly StreamReader sr = new StreamReader(FilePath, System.Text.Encoding.Default);
        readonly StreamWriter sw = new StreamWriter(FilePath);
       


        public void CreateDirectory()
        {
            if (fileInf.Exists)
            {
                Console.WriteLine("Директория уже существует");

            }
            else
            {
                Console.WriteLine("Создание директории");

                Directory.CreateDirectory(DirectoryPath);
                Console.WriteLine("Директория создана");

            }
        }
        public void ReadLogFile(string value)
        {
            try
            {

                if (value != null)
                {
                    Console.WriteLine("Message is " + value);
                    sw.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("message is null");
                }
            }
            catch (Exception e)
            {
                sw.WriteLine(e.Message);
            }
        }


        public void CreateLogFile()
        {



            if (!File.Exists(FilePath))
            {
                
                if (FilePath != null)
                {
                    Create(FilePath);
                    ReadLogFile("Файл создан");
                }

            }
        }



        

        public void DeleteLogFile()
        {
            Console.WriteLine("Удаление файла");

            Console.ReadKey();
            Delete(FilePath);
            if (Exists(FilePath))
            {
                Console.WriteLine("Файл не был удалён");
            }
            else
            {
                Console.WriteLine("Файл был удалён");
            }
        }
    }
}