using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Declare Local (Implicit)
         
			Use Case: Lets you generate an implicit declaration for an 
			undeclared local variable.
         
			Available: When the caret is on an undeclared variable 
			reference.
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class DeclareLocalImplicit
	{
		public int CalculateCircleArea(int radius)
		{
			return radius * radius * pi;
		}
	}
}
