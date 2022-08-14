using System;
using System.Collections.Generic;
using System.Text;

//ConcreteBuilder - This is a class which implements the Builder interface to create a complex product.
namespace BuilderPattern
{
    public class Car : AbstractVehicleBuilder
    {
        Vehicle vehicle = new Vehicle();
        public override void SetEngineNumber()
        {
            vehicle.EngineNumber = "A47";
        }

        public override void SetModelNumber()
        {
            vehicle.Model = "v1";
        }
        public override Vehicle GetVehicle()
        {
            return vehicle;
        }
    }
}
