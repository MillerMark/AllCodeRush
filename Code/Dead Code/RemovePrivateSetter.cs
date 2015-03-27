using System;

namespace AllCodeRush.Code.DeadCode.RemovePrivateSetter
{
	/* •———————————————————————————————————————————————————————•
		Feature: Remove Private Setter
        
		Use Case: Removes an unused parameter from a method 
	  declaration and updates all calls accordingly.
	 
	  Available: When the caret is within the declaration of a 
	  method parameter and that parameter is unused within the 
	  method. 
	 •———————————————————————————————————————————————————————• */
	public class Customer
	{
		private DiscountLevelEnum _discountLevel;
		public DiscountLevelEnum DiscountLevel
		{
			get { return _discountLevel; }
			set
			{
				_discountLevel = value;
			}
		}
		
		private Customer()
		{
			// Setup default discountLevel
			DiscountLevel = DiscountLevelEnum.Bronze;
		}
 		#region Support
		public enum DiscountLevelEnum
		{
			Gold,
			Silver,
			Bronze
		}
		#endregion
	}
}
