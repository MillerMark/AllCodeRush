using System;
using System.Linq;
using System.Collections.Generic;
using AllCodeRush.Space;
using AllCodeRush.Space.Bodies;
using AllCodeRush.Space.Bodies.Planets;
using AllCodeRush;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Optimize Namespace References
         
	    Use Case: Removes unused namespace references.
	 
			Available: When the caret is on a using statement. 
		 •—————————————————————————————————————————————————————————• */
	public class OptimizeNamespaceReferences
	{
		public double CalculateGravitationalConstant()
		{
			return 9.8;	
		}
	}
}
