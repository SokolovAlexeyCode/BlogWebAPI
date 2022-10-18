using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SokolDev.DataAccess;
using SokolDev.Settings.SettingModels;

namespace SokolDev.SQLiteAccess
{
    public class SQLiteDbContext : BloggingContext
    {
        private readonly IOptions<DataStorageOptions> _dataStorageOptions;

        public SQLiteDbContext()
        {
            
        }

        public SQLiteDbContext(IOptions<DataStorageOptions> dataStorageOptions) : base()
        {
            _dataStorageOptions = dataStorageOptions;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured)
                return;

            // It's so because I tried to use migrations creation 
            // In that case I use Package Manager Console and commands Add-Migration InitialCreate
            // In that time we don't have DI-container and it occurs NullRefException
            var sqLiteConnectionStringSettingsValue = _dataStorageOptions == null? 
                "Data Source=C:\\sqlite_db\\BlogPosts.db;" :
                _dataStorageOptions.Value.ConnectionStringsOptions.SQLite;

            
            optionsBuilder.UseSqlite(sqLiteConnectionStringSettingsValue);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //The place for using Fluent API if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}