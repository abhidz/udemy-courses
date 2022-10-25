using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public void Update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
        }
    }
}
