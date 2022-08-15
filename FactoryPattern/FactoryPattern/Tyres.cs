using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Tyres : ITyres
    {
        public int GetNumberOfTyres(string type)
        {
            int _tyresCount = 0;
            if (type == "TwoWheeler")
                _tyresCount = 2;
            else
                _tyresCount = 4;
            return _tyresCount;
        }
    }
}
