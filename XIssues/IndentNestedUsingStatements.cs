using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.XIssues
{
	public class IndentNestedUsingStatements
	{

		// IndentNestedUsingStatements does not appear to work here
		private void MethodName()
		{
			using (IDisposable Disp1 = new Disposable())
			using (IDisposable Disp2 = new Disposable())
			{
				using (IDisposable Disp3 = new Disposable())
				using (IDisposable Disp4 = new Disposable())
				{

				}
			}
		}
	}
}
