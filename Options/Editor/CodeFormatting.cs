using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Options.Editor
{
	/* •———————————————————————————————————————————————————————•
		  Option Set: Editor \ Code Formatting
        
		  Use Case: Lets you customize style of code created or 
			adjusted by CodeRush.
		 •———————————————————————————————————————————————————————• */
	public class CodeFormatting
	{
		// Open Options. Ctrl+Shift+Alt+O
		// Options: Editor\Code Formatting
		// Wrapping

		// Settings affect templates
		// ie Methods, Properties

		// Settings affect Refactorings
		// ie Extract Method, Extract Property
		bool a, b, c, d, e, f;
		private bool ComplexMethod()
		{
			if (a && b && c && d && e && f)
				return true;
			else
				return false;
		}

		// Settings affect CodeProviders
		// ie Declare Method, Declare Property
		public void AnotherComplexMethod()
		{
			int StartPoint = 0;
			Initialize(StartPoint);
			CalculateNextPosition(GetCurrentPosition);
		}
		private int CalculateNextPosition(int CurrentPosition)
		{
			return CurrentPosition + 1;
		}
	}
	#region Support
	public class Disposable : IDisposable
	{
		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
	#endregion
	//Report c -> Try catch bug
	// Ability for classes and delegates to have separate "in-new file" settings.
  // interfaces structs
}
