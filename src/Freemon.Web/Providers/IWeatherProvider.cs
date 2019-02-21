using System.Collections.Generic;
using Freemon.Web.Models;

namespace Freemon.Web.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
