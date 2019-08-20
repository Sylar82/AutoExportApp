using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AutoExportApp
{
    public class ExportItemsInFile
    {
        public void SelectItems()
        {
            using(DataBaseContext db = new DataBaseContext())
            {
                var SelectedItems = db.Items.FromSql("SELECT * FROM public.Items WHERE Name LIKE '%Алексин%'").ToList();
                
               
                    Console.WriteLine(SelectedItems);
            }
        }
    }
}