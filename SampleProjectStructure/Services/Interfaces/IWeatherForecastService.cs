using System.Collections.Generic;
using SampleProjectStructure.Models;

namespace SampleProjectStructure.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForNDays(int numOfDays);
    }
}