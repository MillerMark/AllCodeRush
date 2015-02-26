using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
    public class ConvertToConstant
    {
        private double _PI= 3.14;
        public double GetCircleArea(int radius)
        {
            return _PI * radius * radius;
        }
    }
}
