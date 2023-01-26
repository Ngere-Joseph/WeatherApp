using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class WeatherForecast
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
    }
}