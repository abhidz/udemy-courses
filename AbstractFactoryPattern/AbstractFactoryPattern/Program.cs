using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            var landAnimal = animalFactory.GetAnimal("Cat");
            Console.WriteLine(landAnimal.Speak());
            Console.WriteLine(animalFactory.GetType().Name);
            Console.ReadLine();
        }
    }
}
