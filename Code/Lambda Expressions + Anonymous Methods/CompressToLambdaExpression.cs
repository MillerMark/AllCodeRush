using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCodeRush.Code.LambdaExpressionsAnonymousMethods
{
	/* •———————————————————————————————————————————————————————•
		Feature: Compress to Lambda Expression
        
		Use Case: Converts an anonymous method to a corresponding 
	  lambda expression.
	 
	  Available: When the caret is on a delegate statement 
	  within an anonymous method declaration. 
	 •—————————————————————————————————————————————————————————• */
	public class CompressToLambdaExpression
	{
		Func<string, int> func = delegate(string s) { return s.Length; };
	}
}
