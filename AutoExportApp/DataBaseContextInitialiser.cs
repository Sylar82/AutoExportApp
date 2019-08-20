using System.Collections.Generic;
using System.Data.Entity;

namespace AutoExportApp
{
    public class DataBaseContextInitialiser :
        DropCreateDatabaseAlways<DataBaseContext>

    {
        protected override void Seed(DataBaseContext db)
        {
            List<DataBaseItem> items = new List<DataBaseItem>
            {
                new DataBaseItem {Id = 4, Name = "СКЗ №207 п.Чернь", UpdateDateTime = "20.08.2019 09:48:58"},
                new DataBaseItem {Id = 6, Name = "СКЗ №207 п.Чернь", UpdateDateTime = "20.08.2019 11:09:05"},
                new DataBaseItem {Id = 9, Name = "СКЗ №207 п.Чернь", UpdateDateTime = "20.08.2019 12:16:01"},
                new DataBaseItem {Id = 11, Name = "СКЗ №207 п.Чернь", UpdateDateTime = "20.08.2019 12:38:17"},
                new DataBaseItem {Id = 58, Name = "СКЗ №31 г.Советск", UpdateDateTime = "19.08.2019 17:51:54"},
                new DataBaseItem {Id = 59, Name = "СКЗ №31 г.Советск", UpdateDateTime = "20.08.2019 15:43:34"},
                new DataBaseItem {Id = 54, Name = "СКЗ №31 г.Советск", UpdateDateTime = "20.08.2019 15:42:59"},
                new DataBaseItem {Id = 142, Name = "СКЗ №5 г.Алексин", UpdateDateTime = "20.08.2019 15:43:33"},
                new DataBaseItem {Id = 194, Name = "СКЗ №5 г.Алексин", UpdateDateTime = "20.08.2019 15:43:14"},
                new DataBaseItem {Id = 152, Name = "СКЗ №5 г.Алексин", UpdateDateTime = "20.08.2019 15:42:47"},
                new DataBaseItem {Id = 157, Name = "СКЗ №5 г.Алексин", UpdateDateTime = "20.08.2019 15:43:48"}
            };
                    

                    foreach (DataBaseItem item in items)
                        db.Items.Add(item);

                    db.SaveChanges();
                    base.Seed(db);



                    


        }
    }

    }
