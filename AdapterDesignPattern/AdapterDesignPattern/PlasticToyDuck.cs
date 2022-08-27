using System;

namespace AdapterDesignPattern
{
    class PlasticToyDuck : IToyDuck
    {
        public void squeak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
