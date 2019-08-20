using Microsoft.EntityFrameworkCore;



namespace AutoExportApp
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
            // Установить новый инициализатор
            Database.SetInitialiser<DataBaseContext>(new DataBaseContextInitialiser());
        }

        public DbSet<DataBaseItem> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Itemsdb;Username=postgres;Password=password");
        }
    }
}