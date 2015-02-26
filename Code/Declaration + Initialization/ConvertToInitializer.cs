using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
    public class ConvertToInitializer
    {
        public Building CreateBuilding()
        {
            Building building = new Building();
            building.Floors = 5;
            building.Sublevels = 2;
            return building;
        }
    }
}