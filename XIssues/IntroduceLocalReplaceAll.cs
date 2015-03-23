using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCodeRush.XIssues
{
	public class IntroduceLocalReplaceAll
	{
		public void Calculate()
		{
			int a = 1, b = 2, c = 3;

			int result = (a + b) * (a + b) / c;
			int result2 = (a + b) * 5;
			int result3 = a + b + 42 * (a + b);

			// Note the follow a + b is not picked up.
			int result4 = 42 + a + b * (a + b);
			// but this one is
			int result5 = 42 + a + b;
		}
	}
}