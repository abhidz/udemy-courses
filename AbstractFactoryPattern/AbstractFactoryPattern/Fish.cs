using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Fish : IAnimal
    {
        public string Speak()
        {
            return "shee";
        }
    }
}
