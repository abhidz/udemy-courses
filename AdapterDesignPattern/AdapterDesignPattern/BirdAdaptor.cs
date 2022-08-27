using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    public class BirdAdaptor : IToyDuck
    {
        private readonly IBird bird;
        public BirdAdaptor(IBird bird)
        {
            // we need reference to the object we
            // are adapting
            this.bird = bird;
        }
        public void squeak()
        {
            bird.makeSound();
        }
    }
}
