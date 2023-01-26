using Microsoft.AspNetCore.Mvc;
using Models;

namespace WeatherApp2.Repository
{
    public interface IWeatherRepository
    {
        Task<IEnumerable<WeatherForecast>> GetWeathers();
        Task<WeatherForecast> GetWeather(Guid Id);
        Task AddWeather(WeatherForecast weatherForecast);

        void UpdateWeather(WeatherForecast weatherForecast, Guid Id);

        Task DeleteWeather(Guid Id);

    }
}
