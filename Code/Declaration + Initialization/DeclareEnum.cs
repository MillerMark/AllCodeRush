using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
		  Feature: Declare Enum
        
		  Use Case: Lets you create a new enum from example code.
         
		  Available: When the caret is positioned on a reference to 
		  a non-existent enumeration type.
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class DeclareEnum
	{
		public double CalculateDiscountPCent(DiscountLevelEnum discountLevel)
		{
			switch (discountLevel)
			{
				case DiscountLevelEnum.Platinum:
					return 15.0;
				case DiscountLevelEnum.Gold:
					return 10.0;
				case DiscountLevelEnum.Silver:
					return 5.0;
				case DiscountLevelEnum.Bronze:
					return 2.5;
				default:
					throw new Exception("This cannot happen");
			}
		}
	}
}
