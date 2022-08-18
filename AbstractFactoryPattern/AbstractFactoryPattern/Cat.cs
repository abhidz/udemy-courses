using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow";
        }
    }
}

//Cat,Lion,Octopus and Fish are the classes which implements the AbstractProduct interface to create a product.