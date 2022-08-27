using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBird bird = new Sparrow();
            bird.fly();
            bird.makeSound();

            IToyDuck toyDuck = new PlasticToyDuck();
            toyDuck.squeak();

            BirdAdaptor birdAdaptor = new BirdAdaptor(bird);
            birdAdaptor.squeak();
            Console.ReadLine();
        }
    }
}
