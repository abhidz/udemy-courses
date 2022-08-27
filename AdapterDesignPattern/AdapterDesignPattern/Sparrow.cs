using System;

namespace AdapterDesignPattern
{
    class Sparrow : IBird
    {
        public void fly()
        {
            Console.WriteLine("Flying");
        }

        public void makeSound()
        {
            Console.WriteLine("Cgirr chirr");
        }
    }
}
