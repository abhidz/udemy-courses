using System;
using System.Collections.Generic;
using System.Text;

//Builder - This is an interface/abstarct class which is used to define all the steps required to create a product.Here Vehicle is the product
namespace BuilderPattern
{
    public abstract class AbstractVehicleBuilder
    {
        public abstract void SetEngineNumber();

        public abstract void SetModelNumber();

        public abstract Vehicle GetVehicle();
    }
}
