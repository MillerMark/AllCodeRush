using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    /* •———————————————————————————————————————————————————————•
        Feature: Initialize Conditionaly
        
        Use Case: Let's you make a variable's initialization 
        conditional by moving said initialization to a new else 
        block.
         
        Available: When the cursor is on a variable initialization
        provided that the following if block contains an assignment 
        statement for this variable.
       •———————————————————————————————————————————————————————• */

    public class InitializeConditionaly
    {
        private string GetAgeDescription(int Age)
        {
            string Description = "Young";
            if (Age > 70)
            {
                Description = "Young at Heart";
            }
            return Description;
        }
    }
}
