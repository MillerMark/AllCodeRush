using System;

namespace AllCodeRush.Code.DeadCode
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
		Feature: Remove Redundant Type Specification
        
		Use Case: Removes redundant type specifications from 
	  lambda expression parameters.

	  Available: When the caret is within a lambda expression 
	  parameters list. 
	 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
	public class RemoveRedundantTypeSpecification
	{
		static void Main(string[] args)
		{
			X((int a, int b, int c) =>
			{
				int x = a + b + c;
			});
		}

		#region Support
		private static void X(Action<int, int, int> action)
		{

		}
		#endregion
	}
}
