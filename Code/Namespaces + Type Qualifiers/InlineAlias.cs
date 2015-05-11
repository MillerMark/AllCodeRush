using System;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Inline Alias
         
	    Use Case: Replaces *all* references to an aliased type 
		  or namespace with the full name of the type or the 
	    namespace.
	 
			Available: When the cursor is on the alias declaration. 
		 •—————————————————————————————————————————————————————————• */
	using Generic = System.Collections.Generic;

	public class InlineAlias
	{
		public void OrderAwesomeSoftware()
		{
			Generic.List<ShoppingBasketItem> list = new Generic.List<ShoppingBasketItem>();
			list.Add(new ShoppingBasketItem("CodeRush", 20));
			list.Add(new ShoppingBasketItem("DXperience Universal", 20));
			list.Add(new ShoppingBasketItem("DevExtreme", 20));
		}
	}
}
