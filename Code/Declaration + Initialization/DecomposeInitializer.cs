using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
    /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
     * Feature: Decompose Initializer
     * 
     * Use Case: Lets you convert an object initializer to the 
     * object constructor call, followed by lines that initialize 
     * object properties.
     *  
     * Available: When the cursor is placed on the name of the 
     * initialized object. 
     * 
     * See also: Convert To Initializer
     * 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

    public class DecomposeInitializer
    {
        public Building CreateBuilding()
        {
            return new Building() { Floors = 5, Sublevels = 2 };
        }
    }
}
