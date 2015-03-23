using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.XIssues
{
	public class InlineRecentAssignment
	{
		// TODO: Change this into a proper use case.
		public void MethodName()
		{
			// Broken if executed on this line.
			int s = 1;
			// Broken if executed on this line.
			string String1 = "Value - " + s;
			s = 42;
			// Works here though.
			string String2 = "Value - " + s;
		}
	}
}
