using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// Observer interface. Also known as suscribers. They simply listen to the changes in the subjects
    /// The Observer defines an updating interface for objects that should be notified of changes in a Subject
    /// </summary>
    public interface IObserver
    {
        void Update(string availability);
    }
}
