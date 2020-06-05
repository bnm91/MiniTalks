using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.TraditionalObserverPattern
{
    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
