using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Migrations.Operations;

namespace AutoExportApp
{
    public class UploadDataBase : NpgsqlDropDatabaseOperation
    {
        public  void UploadItems()
        {
            string a = "";
            Console.WriteLine("Инициализировать базу данных?(y/n)");
            a = Console.ReadLine();
            
            if(a == "y")
            {

                using (DataBaseContext db = new DataBaseContext())
                {


                    DataBaseItem item1 = new DataBaseItem()
                        {Id = 4, Name = "СКЗ №207 п.Чернь", UpdateDateTime = "20.08.2019 09:48:58"};
                    DataBaseItem item2 = new DataBaseItem()
                        {Id = 6, Name = "СКЗ №207 п.Чернь", UpdateDateTime = "20.08.2019 11:09:05"};
                    DataBaseItem item3 = new DataBaseItem()
                        {Id = 9, Name = "СКЗ №207 п.Чернь", UpdateDateTime = "20.08.2019 12:16:01"};
                    DataBaseItem item4 = new DataBaseItem()
                        {Id = 11, Name = "СКЗ №207 п.Чернь", UpdateDateTime = "20.08.2019 12:38:17"};
                    DataBaseItem item5 = new DataBaseItem()
                        {Id = 58, Name = "СКЗ №31 г.Советск", UpdateDateTime = "19.08.2019 17:51:54"};
                    DataBaseItem item6 = new DataBaseItem()
                        {Id = 59, Name = "СКЗ №31 г.Советск", UpdateDateTime = "20.08.2019 15:43:34"};
                    DataBaseItem item7 = new DataBaseItem()
                        {Id = 54, Name = "СКЗ №31 г.Советск", UpdateDateTime = "20.08.2019 15:42:59"};
                    DataBaseItem item8 = new DataBaseItem()
                        {Id = 142, Name = "СКЗ №5 г.Алексин", UpdateDateTime = "20.08.2019 15:43:33"};
                    DataBaseItem item9 = new DataBaseItem()
                        {Id = 194, Name = "СКЗ №5 г.Алексин", UpdateDateTime = "20.08.2019 15:43:14"};
                    DataBaseItem item10 = new DataBaseItem()
                        {Id = 152, Name = "СКЗ №5 г.Алексин", UpdateDateTime = "20.08.2019 15:42:47"};
                    DataBaseItem item11 = new DataBaseItem()
                        {Id = 157, Name = "СКЗ №5 г.Алексин", UpdateDateTime = "20.08.2019 15:43:48"};








                    db.Items.Attach(item1);
                    //db.Items.Add(item1);
                    db.Items.Attach(item2);
                    //db.Items.Add(item2);
                    db.Items.Attach(item3);
                    //db.Items.Add(item3);
                    db.Items.Attach(item4);
                    //db.Items.Add(item4);
                    db.Items.Attach(item5);
                    //db.Items.Add(item5);
                    db.Items.Attach(item6);
                    //db.Items.Add(item6);
                    db.Items.Attach(item7);
                    //db.Items.Add(item7);
                    db.Items.Attach(item8);
                    //db.Items.Add(item8);
                    db.Items.Attach(item9);
                    //db.Items.Add(item9);
                    db.Items.Attach(item10);
                    //db.Items.Add(item10);
                    db.Items.Attach(item11);
                    //db.Items.Add(item11);
                    db.SaveChanges();


                }
                
                

            }
            else 
            {
               Console.WriteLine("База данных не проинициализирована, либо уже существует");                  
            }
        }

        public void DeleteItems()
        {
            using (DataBaseContext db = new DataBaseContext() )
            {
                
            }
        }
    }
}
    

 