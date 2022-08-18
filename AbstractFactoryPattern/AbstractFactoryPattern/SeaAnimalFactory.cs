namespace AbstractFactoryPattern
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType.Equals("Octopus"))
                return new Octopus();
            return new Fish();
        }
    }
}
//This is a class which implements the AbstractFactory interface to create concrete products.//