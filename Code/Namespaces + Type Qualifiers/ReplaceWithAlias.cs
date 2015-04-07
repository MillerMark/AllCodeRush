using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Inline Alias
         
	    Use Case: Expands the alias at the caret.
	 
			Available: When the edit cursor or caret is on a type or 
	    namespace alias. 
		 •—————————————————————————————————————————————————————————• */
	using Generic = System.Collections.Generic;

	public class ReplaceWithAlias
	{
		private void CreateBasket()
		{
			Generic.List<ShoppingBasketItem> list = new Generic.List<ShoppingBasketItem>();
			list.Add(new ShoppingBasketItem("Awesome UI Design - Mark Miller (Book)", 10));
			list.Add(new ShoppingBasketItem("C# in Depth- Jon Skeet (Book)", 10));

		}
	}
}
