using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApiContext _apiContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApiContext apiContext)
        {
            _logger = logger;
            _apiContext = apiContext;
        }

        [HttpGet]
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

        [HttpPost("Quot")]
        public double Quot(int x, int y)
        {
            if (y <= 0) throw new ArgumentOutOfRangeException("Y must bi higher than 0");
            return x / y;
        }

        [HttpPost("Prod")]
        public double Prod(int x, int y)
        {
            return x * y;
        }

        [HttpGet]
        public string GetSummary(int x)
        {
            return Summaries[x];
        }

        [HttpPost]
        public string[] PostSummary(string item)
        {
            var items = Summaries.Append(item);
            return items.ToArray();
        }

        [HttpDelete]
        public string[] RemoveSummary(int x)
        {
            var items = Summaries.ToList();
            items.RemoveAt(x);
            return items.ToArray();
        }

        [HttpPut]
        public string[] UpdateSummary(int x, string y)
        {
            var items = Summaries.ToList();
            items[x] = y;
            return items.ToArray();
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetAllFromDB()
        {
            return _apiContext.WeatherForecasts.ToList();
            
        }

        [HttpPost]
        public WeatherForecast AddForecastToDB(WeatherForecast data)
        {
            var result = _apiContext.WeatherForecasts.Add(data);
            _apiContext.SaveChanges();
            return result.Entity;
        }

        [HttpPut]
        public WeatherForecast UpadateForecastToDB(WeatherForecast data)
        {
            var result = _apiContext.WeatherForecasts.Update(data);
            _apiContext.SaveChanges();
            return result.Entity;
        }

/*        [HttpDelete]
        public WeatherForecast DeleteForecastToDB(WeatherForecast data)
        {
            var result = _apiContext.WeatherForecasts.Delete(data);
            _apiContext.SaveChanges();
            return result.Entity;
        }

        [HttpGet]
        public WeatherForecast GetForecastToDBById(WeatherForecast data)
        {
            var result = _apiContext.WeatherForecasts.Get(data);
            _apiContext.SaveChanges();
            return result.Entity;

        }*/

    }
}
