using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern_Practice.Observer
{
    interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
