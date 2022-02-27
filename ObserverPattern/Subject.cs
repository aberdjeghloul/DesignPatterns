using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// Concrete class Subject. Store state of interest to Observer objects and also responsible for sending a notification to its observers when its state changes
    /// </summary>
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }
        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string getAvailability()
        {
            return Availability;
        }

        public void setAvailability(string availability)
        {
            Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Product Name : " + ProductName + ", product Price: " + ProductPrice + " is Now available. So notifyng all Registered users!");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.Update(Availability);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added: " + ((Observer)observer).UserName);
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}
