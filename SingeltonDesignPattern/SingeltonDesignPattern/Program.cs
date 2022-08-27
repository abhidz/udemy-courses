using System;

namespace SingeltonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singelton = Singelton.GetInstance();
            var singelton2 = Singelton.GetInstance();
            if(singelton == singelton2 &&  singelton.Equals(singelton2))
            {
                Console.WriteLine("Singeltion gets implemented");
            }
            else
            {
                Console.WriteLine("Error in implemeting singelton");
            }
            Console.ReadLine();
        }
    }
}

