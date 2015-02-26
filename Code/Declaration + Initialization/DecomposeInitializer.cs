using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
    public class DecomposeInitializer
    {
        public Building CreateBuilding()
        {
            return new Building() { Floors = 5, Sublevels = 2 };
        }

    }
}
