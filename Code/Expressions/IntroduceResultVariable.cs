using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Introduce Result Variable
        
			Use Case: Lets you introduce a variable to accept a 
			value, replacing early-exit return statements with 
			assignments to the variable and consolidating multiple 
			method exit points into a single one.
         
			Available: When the caret is on a return statement.
        
			See also: Inline Result
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class IntroduceResultVariable
	{
		public bool isThisYourCard(bool CardIsAceOfSpades)
		{
			if (CardIsAceOfSpades)
				return true;
			else
				return false;
		}
	}
}
