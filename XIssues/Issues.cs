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
	public class InlineConstant
	{
		/* Question: Why can this not be invoked from the declaration of the constant */
		public double GetCircleArea(int radius)
		{
			const double PI = 3.14;
			return PI * radius * radius;
		}
	}

	public class UseEqualityOperator
	{
		private void TestEquality()
		{
			//TODO: Does Not appear to work.
			bool result = 1.Equals(2);
		}
	}
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

	public class PromoteToParameterOptional
	{
		public void Log(string Message)
		{

			//TODO: Why is this refactoring not available here?
			Console.WriteLine("Error" + Message);

			// But works fine here.
			string LogType = "Error";
			Console.WriteLine(LogType + Message);
		}

		#region Support
		public void main()
		{
			Log("Starting Application");
			try
			{
				throw new Exception("Bad things happened");
			}
			catch (Exception ex)
			{
				Log(String.Format("Something went very wrong:{0}", ex.Message));
			}
			Log("Ending Application");
		}
		#endregion
	}
}
