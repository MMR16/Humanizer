using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace HumanizerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("humanizer")]


        public IActionResult GetHumanizer()
        {
            int number = 95_599_546;
            string wordsInArabic = number.ToWords(new CultureInfo("ar"));
            string wordsInEnglish = number.ToWords(new CultureInfo("en"));
            return Ok(new { number, wordsInArabic, wordsInEnglish });
        }
    }
}
