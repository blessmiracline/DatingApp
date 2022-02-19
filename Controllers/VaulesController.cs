using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel;
//using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    // [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }

        //GET api/values
        [HttpGet]
        public IActionResult GetValues()
        {
            var values = _context.Values.ToList();
            return Ok(values);
        }
        /*private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }*/
        //GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            var value = _context.Values.FirstOrDefault(x =>x.Id == id);
            return Ok(value);

        }
        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        { }
        //PUT api/values/5

        [HttpPut("{id}")]
        public void Put([FromBody] string value)
        { }


        //DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        { }

        // var rng = new Random();
        //  return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        /* {
             Date = DateTime.Now.AddDays(index),
             TemperatureC = rng.Next(-20, 55),
             Summary = Summaries[rng.Next(Summaries.Length)]
         })
         .ToArray();*/

    }
}
