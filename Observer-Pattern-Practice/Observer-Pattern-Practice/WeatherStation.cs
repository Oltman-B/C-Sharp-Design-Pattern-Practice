using System;
using Observer_Pattern_Practice.Displays;
using Observer_Pattern_Practice.WeatherStationData;

namespace Observer_Pattern_Practice
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Weather Station!");
            var weatherData = new WeatherData();
            var currentDisplay = new CurrentConditionDisplay(weatherData);

            weatherData.SetMeasurements(33.4f, 44f,33.2f);
        }
    }
}
