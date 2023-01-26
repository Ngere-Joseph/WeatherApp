using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using WeatherApp2.Repository;

namespace WeatherApp.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherRepository _repository;

        public WeatherForecastController(IWeatherRepository repository)
        {
            _repository = repository;
        }
      
        [HttpGet]
        public async Task<IActionResult> GetWeathers()
        {
            return Ok(await _repository.GetWeathers());
        }

        [HttpPost]
        public async Task<IActionResult> AddWeather(WeatherForecast addWeatherRequest)
        {
            return Ok( _repository.AddWeather(addWeatherRequest));
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetWeather([FromRoute] Guid id)
        {
            var weather = await _repository.GetWeather(id);
            if (weather == null)
            {
                return NotFound();
            }
            return Ok(weather);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateWeather([FromRoute] WeatherForecast updateWeatherRequest, Guid Id)
        {
            var weather = await _repository.GetWeather(Id);
            if (weather != null)
            {
                _repository.UpdateWeather(updateWeatherRequest, Id);
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteWeather(Guid id)
        {
            var weather =  _repository.GetWeather(id);
            if (weather != null)
            {
                _repository.DeleteWeather(id);
                return NoContent();
            }
            return NotFound();
        }
    }
}