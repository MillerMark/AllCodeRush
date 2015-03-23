using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.XIssues
{
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