using System;
using DIExplained.Interfaces;

namespace DIExplained.Services
{
	public class RealWeatherService : IWeatherService
    {
        // Call a real weather API or service to get live data
        // For simplicity, we'll just return a hardcoded value.
        public string GetWeatherInfo() => "Sunny and 25°C (Real Data)";
    }
}

