using System;
using System.Collections.Generic;
using System.Linq;
using SampleProjectStructure.Models;
using SampleProjectStructure.Services.Interfaces;

namespace SampleProjectStructure.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastService()
        {
        }

        // replace this method to use database context instead of reading from hardcoded data
        public IEnumerable<WeatherForecast> GetWeatherForNDays(int numOfDays)
        {
            var rng = new Random();
            return Enumerable.Range(1, numOfDays).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
