using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// Subject interface. Also known as Publisher. When a change occur to a subject it should notify all of its suscribers
    /// The Subject knows its Observers and provides an interface for adding or removing any number of Observer objects
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void AddObserver(IObserver observer);
        void NotifyObservers();
    }
}
