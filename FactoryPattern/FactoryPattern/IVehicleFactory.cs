using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface IVehicleFactory
    {
        ITyres GetNumberOfTyres { get; }

        IWindow GetNumberOfWindows { get; }

    }
}
