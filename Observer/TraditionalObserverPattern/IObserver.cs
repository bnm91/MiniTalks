using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.TraditionalObserverPattern
{
    public interface IObserver
    {
        void Update(string episodeName);
    }
}
