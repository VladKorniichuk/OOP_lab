using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static string[] Summaries = new[]
        {
             "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger _logger;

        public WeatherForecastController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public IActionResult Quot([FromBody] DivideReq request)
        {
            return Ok(request.Numerator / request.Denominator);
        }

        [HttpPost]
        public IActionResult Prod([FromBody] DivideReq request)
        {
            return Ok(request.Numerator / request.Denominator);
        }

        [HttpGet]
        public IActionResult GetSummary([FromQuery] int index)
        {
            return Ok(Summaries[index]);
        }

        [HttpPost]
        public IActionResult PostSummary([FromBody] string newSummary)
        {
            var updatedSummaries = Summaries.ToList();
            updatedSummaries.Add(newSummary);
            Summaries = updatedSummaries.ToArray();
            return Ok(Summaries);
        }

        [HttpDelete]
        public IActionResult RemoveSummary([FromQuery] int index)
        {
            var updatedSummaries = Summaries.ToList();
            updatedSummaries.RemoveAt(index);
            Summaries = updatedSummaries.ToArray();
            return Ok(Summaries);
        }

        [HttpPut]
        public IActionResult UpdateSummary([FromQuery] int index, [FromBody] string newSummary)
        {
            var updatedSummaries = Summaries.ToList();
            updatedSummaries[index] = newSummary;
            Summaries = updatedSummaries.ToArray();
            return Ok(Summaries);
        }

        public class DivideReq
        {
            public double Numerator { get; set; }
            public double Denominator { get; set; }
        }
    }
}