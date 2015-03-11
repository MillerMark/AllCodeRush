using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Pull Member Up
        
			Use Case: Lets you move a member to any base type.
         
			Available: When the caret is on a class member, provided 
			that the base class code is available in the current 
			solution.
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class BaseClass
	{

	}
	public class PullMemberUp : BaseClass
	{
		public void UsefulMethod()
		{

		}

		private void CallingMethod()
		{
			UsefulMethod();
		}
	}
}
