using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern_Practice.Observer
{
    interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
    }
}
