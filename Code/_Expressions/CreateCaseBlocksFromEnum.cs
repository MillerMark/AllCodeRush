using System;

namespace AllCodeRush.Code.Expressions
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Create Case Blocks From Enum
        
			Use Case: Generates Switch/Select statements for each 
      element of the enum at the caret.
         
			Available: When the caret is placed on a reference to an 
			enum.
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

  public class CreateCaseBlocksFromEnum
	{
		private enum DiscountLevel
		{
			Platinum,
			Gold,
			Silver,
			Bronze
		}

		private void OfferDiscount(DiscountLevel discount)
		{
		}

	}
}
