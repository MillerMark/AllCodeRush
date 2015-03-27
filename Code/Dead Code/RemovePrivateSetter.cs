using System;

namespace AllCodeRush.Code.DeadCode.RemovePrivateSetter
{
	/* •———————————————————————————————————————————————————————•
		Feature: Remove Private Setter.
        
		Use Case: Removes an private property setter that simply 
	  assigns a value to a field without any side-effects.
	 
	  Available: When the caret is caret is on a private property 
	  setter, provided that the setter's body contains only one 
	  field initializer. 
	 •—————————————————————————————————————————————————————————• */
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
