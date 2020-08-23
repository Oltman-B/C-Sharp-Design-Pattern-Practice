using System.Collections.Generic;
using Observer_Pattern_Practice.Observer;

namespace Observer_Pattern_Practice.WeatherStationData
{
    class WeatherData : ISubject
    {
        private float temp;
        private float humidity;
        private float pressure;

        private List<IObserver> observers = new List<IObserver>();

        private void measurementsChanged()
        {
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temp, humidity, pressure);
            }
        }


        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
