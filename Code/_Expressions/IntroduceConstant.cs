using System;

namespace AllCodeRush.Code.Expressions
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Introduce Constant
        
			Use Case: Declares a new constant initialized to 
			the value of the string or number at the caret.
         
			Available: When the caret is on a number or string literal.
        
			See also: Inline Constant, Introduce Constant (Local)
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class IntroduceConstant
	{
    public double GetCircleSegmentLength(double radius, double percentageAround)
		{
      // Let's introduce a constant for tau:
      return 6.2831853071 * percentageAround * radius;
		}
	}
}
