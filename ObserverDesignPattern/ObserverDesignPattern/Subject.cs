using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class Subject : ISubject
    {
        private List<IObserver> listOfObservers = new List<IObserver>();
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }

        public Subject(string ProductName, int ProductPrice, string Availability)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.Availability = Availability;
        }

        public string GetAvailability()
        {
            return this.Availability;
        }

        public void  SetAvailability( string Availability)
        {
            this.Availability = Availability;
            Console.WriteLine("Item is available now");
            NotifyObservers();
        }


        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                           + ProductName + ", product Price : "
                           + ProductPrice + " is Now available. So notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in listOfObservers)
            {
                observer.Update(Availability);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            listOfObservers.Add(observer);
            Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
        }

        public void AddObservers(IObserver observer)
        {
            listOfObservers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            listOfObservers.Remove(observer);
        }
    }
}
