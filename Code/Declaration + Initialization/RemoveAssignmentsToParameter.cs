using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Remove Assignments to Parameter
        
			Use Case: Prevents input parameters being modified.
        
			Available: When the caret is on a parameter declaration 
			or reference provided that the parameter has an assignment 
			within the method's body.
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class RemoveAssignmentsToParameter
	{
		public int Add(int left, int right)
		{
			left = left + right;
			return left;
		}
	}
}
