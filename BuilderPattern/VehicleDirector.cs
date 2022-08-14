using System;
using System.Collections.Generic;
using System.Text;

//Director - This is a class that is used to construct an object using the Builder interface/Abstarct class.It communicates with builder and client communicates with it
namespace BuilderPattern
{
    public class VehicleDirector
    {
        private readonly AbstractVehicleBuilder _vehicleBuilder;
        public VehicleDirector(AbstractVehicleBuilder vehicleBuilder)
        {
            _vehicleBuilder = vehicleBuilder;
        }

        public void CreateObjects()
        {
            _vehicleBuilder.SetEngineNumber();
            _vehicleBuilder.SetModelNumber();
        }

        public Vehicle GetVehicle()
        {
            return _vehicleBuilder.GetVehicle();
        }
    }
}
