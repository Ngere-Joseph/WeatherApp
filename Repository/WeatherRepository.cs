using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using NuGet.Protocol.Core.Types;
using WeatherApp2.Models;

namespace WeatherApp2.Repository
{
    public class WeatherRepository : IWeatherRepository
    {
        private WeatherDbContext dbContext;
        public WeatherRepository(WeatherDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeathers()
        {
            //throw new Exception("Custom exception for testing purposes");
            return await dbContext.WeatherForecasts.ToListAsync();
        }

        public async Task<WeatherForecast> GetWeather(Guid Id) =>
            await dbContext.WeatherForecasts
                .SingleOrDefaultAsync(c => c.Id.Equals(Id));
        public async Task AddWeather(WeatherForecast payload)
        {
            var AddWeather = new WeatherForecast
            {
                Id = Guid.NewGuid(),
                Date = payload.Date,
                TemperatureC = payload.TemperatureC,
                Summary = payload.Summary,
            };
            dbContext.Add(AddWeather);
            await dbContext.SaveChangesAsync();
        }
        public void UpdateWeather(WeatherForecast updateWeatherRequest, Guid Id)
        {
            var weather = dbContext.WeatherForecasts.Find(Id);
            weather.Date = updateWeatherRequest.Date;
            weather.TemperatureC = updateWeatherRequest.TemperatureC;
            weather.Summary = updateWeatherRequest.Summary;
            dbContext.SaveChanges();
        }
        public async Task DeleteWeather( Guid id)
        {
            var weather = await dbContext.WeatherForecasts.FindAsync(id);
            dbContext.WeatherForecasts.Remove(weather);
            await dbContext.SaveChangesAsync();
        }

    }
}
