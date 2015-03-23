using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.XIssues
{
	public class InlineConstant
	{
		/* Question: Why can this not be invoked from the declaration of the constant */
		public double GetCircleArea(int radius)
		{
			const double PI = 3.14;
			return PI * radius * radius;
		}
	}
}
