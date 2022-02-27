using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// Concrete Observer. It maintains a reference to a ConcreteSubject object
    /// , stores state that should stay consistent with the subject's 
    /// and implements the Observer updating interface to keep its state consistent with the subject's
    /// </summary>
    public class Observer : IObserver
    {
        public string UserName { get; set; }
        public Observer(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }
        public void Update(string availability)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availability + " on Amazon");
        }
    }
}
