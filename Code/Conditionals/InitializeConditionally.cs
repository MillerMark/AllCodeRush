using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    public class InitializeConditionally
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
