using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Create Case Blocks From Enum
        
			Use Case: Generates Case statements for each element of 
			the current enum.
         
			Available: When the caret is placed on a reference to an 
			enum.
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class CreateCaseBlocksFromEnum
	{
		private enum DiscountLevelEnum
		{
			Platinum,
			Gold,
			Silver,
			Bronze
		}
		private void Test()
		{
			DiscountLevelEnum DiscountLevel = GetDiscountLevel();
		}

		#region Utility
		private DiscountLevelEnum GetDiscountLevel()
		{
			return (DiscountLevelEnum)(new System.Random().Next(3));
		}
		#endregion
	}
}
