using System;
using DIExplained.Interfaces;

namespace DIExplained.Services
{
	public class FakeWeatherService : IWeatherService
    {
        public string GetWeatherInfo() => "Sunny and 25°C (Fake Data)";
    }
}

