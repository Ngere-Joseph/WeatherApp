using Microsoft.EntityFrameworkCore;
using Models;

namespace WeatherApp2.Models
{

    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options)
            : base(options)
        {
        }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}

