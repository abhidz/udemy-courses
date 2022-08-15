using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Window : IWindow
    {
        public int GetNumberOfWindows(string type)
        {
            int _windowCount = 0;
            if (type == "TwoWheeler")
                _windowCount = 0;
            else
                _windowCount = 4;
            return _windowCount;
        }
    }
}
