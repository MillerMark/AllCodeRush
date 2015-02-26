using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
    public class InlineTemp
    {
        public double GetCylinderVolume(int radius, int height)
        {
            int h = height;
            int r = radius;
            return r * r * h * Math.PI;
        }
    }
}
