using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SokolDev.Settings.SettingModels;

namespace BlogWebAPI.Controllers
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
        
        private readonly IOptions<DataStorageOptions> _dataStorageOptions;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, 
            IOptions<DataStorageOptions> dataStorageOptions)

        {
            _logger = logger;
            _dataStorageOptions = dataStorageOptions;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<string> Get()
        {
            var t_1 = _dataStorageOptions.Value.StorageType;
            var t_2 = _dataStorageOptions.Value.ConnectionStringsOptions;

            return Summaries;
        }
    }
}