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

            // Example of composition, types can be added and removed at run-time.
            weatherData.RemoveObserver(currentDisplay);

            weatherData.SetMeasurements(99.4f, 22.3f, 12.3f);
        }
    }
}
