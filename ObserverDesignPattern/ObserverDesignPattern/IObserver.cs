using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public interface IObserver
    {
        void Update(string availability);
    }
}
