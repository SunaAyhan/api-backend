using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sehir_Rehberi.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sehir_Rehberi.API.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
        
    {
        
        private DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //private readonly ILogger<ValuesController> _logger;

        //public ValuesController(ILogger<ValuesController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]
        public async Task<ActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult> GetValue(int id)
        {
            Models.Value value = await _context.Values.FirstOrDefaultAsync(value => value.Id == id);
                return Ok(value);
            
        }
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
