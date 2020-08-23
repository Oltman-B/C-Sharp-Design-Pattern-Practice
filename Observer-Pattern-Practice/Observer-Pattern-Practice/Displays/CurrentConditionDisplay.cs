using System;
using System.Collections.Generic;
using System.Text;
using Observer_Pattern_Practice.Observer;

namespace Observer_Pattern_Practice.Displays
{
    class CurrentConditionDisplay : IDisplayable, IObserver
    {
        private float temp;
        private float humidity;
        private float pressure;

        private ISubject weatherData;

        public CurrentConditionDisplay(ISubject s)
        {
            weatherData = s;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current Temp: {temp:N1}F. Humidity is {humidity:N1}%. Pressure is {pressure:N1}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
