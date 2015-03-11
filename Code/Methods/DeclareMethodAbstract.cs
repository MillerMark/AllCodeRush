using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Declare Method (Abstract)
        
			Use Case: Lets you generate an abstract method where none 
			exists based on an existing call to that method.
         
			Available: When the caret is on a statement calling an undeclared method.
        
			See also: Declare Method
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public abstract class DeclareMethodAbstract
	{
		public void ExistingMethod()
		{
			OtherMethod(1);
		}
	}
}
