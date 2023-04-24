using Microsoft.EntityFrameworkCore;
using WeatherAPI.Models;

namespace WeatherAPI
{
    public class WeatherContext : DbContext
    {
        public DbSet<RawDataTableModel> RawData { get; set; }
        public DbSet<TodayRawTableModel> TodayRaw { get; set; }
        public DbSet<MaxPerHourTableModel> MaxPerHour { get; set; }
        public DbSet<MinPerHourTableModel> MinPerHour { get; set; }
        public DbSet<AvgPerHourTableModel> AvgPerHour { get; set; }
        public DbSet<MaxPerDayTableModel> MaxPerDay { get; set; }
        public DbSet<MinPerDayTableModel> MinPerDay { get; set; }
        public DbSet<AvgPerDayTableModel> AvgPerDay { get; set; }
        public DbSet<AvgPerTenMinTableModel> AvgPerTenMin { get; set; }
        public DbSet<LogsModel> Logs { get; set; }
        public DbSet<CSVMapModel> CSVMap { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=" + Environment.CurrentDirectory + @"\Weather.db");
    }
}
