using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var scooterDirector = new VehicleDirector(new Scooter());
            scooterDirector.CreateObjects();
            var scooterSpecifications = scooterDirector.GetVehicle();
            Console.WriteLine("Scooter EngineNumber =" + scooterSpecifications.EngineNumber);
            Console.WriteLine("Scooter Model =" + scooterSpecifications.Model);


            var carDirector = new VehicleDirector(new Car());
            carDirector.CreateObjects();
            var carSpecifications = carDirector.GetVehicle();
            Console.WriteLine("Car EngineNumber =" + carSpecifications.EngineNumber);
            Console.WriteLine("Car Model =" + carSpecifications.Model);
        }
    }
}


//https://www.c-sharpcorner.com/article/builder-design-pattern-using-c-sharp/
