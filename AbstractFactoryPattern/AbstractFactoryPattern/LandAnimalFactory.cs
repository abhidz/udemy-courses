namespace AbstractFactoryPattern
{
    internal class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType.Equals("Cat"))
                return new Cat();
            return new Lion();
        }
    }
}
//This is a class which implements the AbstractFactory interface to create concrete products.