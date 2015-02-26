using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
    public class InlineMethod
    {
        public double GetVolumeOfCylinder(int radius, int height)
        {
            return GetAreaOfCircle(radius) * height;
        }
        private static double GetAreaOfCircle(int radius)
        {
            return radius * radius * Math.PI;
        }
    }
}
