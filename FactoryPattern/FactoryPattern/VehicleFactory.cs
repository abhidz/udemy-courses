using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class VehicleFactory : IVehicleFactory
    {
        private readonly ITyres _getNumberOfTyres;
        public ITyres GetNumberOfTyres
        {
            get
            {
                if (_getNumberOfTyres is null)
                    return new Tyres();
                return _getNumberOfTyres;
            }
        }

        private readonly IWindow _getNumberOfWindows;
        public IWindow GetNumberOfWindows
        {
            get
            {
                if (_getNumberOfWindows is null)
                    return new Window();
                return _getNumberOfWindows;
            }
        }
    }
}
