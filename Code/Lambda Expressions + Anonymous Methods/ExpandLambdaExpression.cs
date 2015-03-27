using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.LambdaExpressionsAnonymousMethods
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
		Feature: Expand Lambda Expression
        
		Use Case: Converts a Lambda Expression into an anonymous 
	  method.
	 
	  Available: When the caret is on the left side of a lambda 
	  operator or on a lambda operator (=>). 
	 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
	public class ExpandLambdaExpression
	{
		Func<string, int> func = delegate(string s) { return s.Length; };

	}
}
