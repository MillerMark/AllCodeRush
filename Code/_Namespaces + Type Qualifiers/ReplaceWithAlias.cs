using System;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
	    Feature: Replace with Alias
         
	    Use Case: Expands the alias at the caret.
	 
			Available: When the edit cursor or caret is on a type or 
	    namespace alias. 

      See Also: Inline Alias
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	using Generic = System.Collections.Generic;

	public class ReplaceWithAlias
	{
		public void CreateBasket()
		{
			Generic.List<ShoppingBasketItem> list = new Generic.List<ShoppingBasketItem>();
			list.Add(new ShoppingBasketItem("Awesome UI Design - Mark Miller (Book)", 10));
			list.Add(new ShoppingBasketItem("C# in Depth- Jon Skeet (Book)", 10));

		}
	}
}
