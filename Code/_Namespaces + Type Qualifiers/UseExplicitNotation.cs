using System;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
      Feature: Use Explicit Notation
         
      Use Case: Converts a short form of a nullable type 
      reference to its explicit form.
	 
      Available: When the cursor is on a short form reference to 
      the nullable type.

      See also: Use Short Notation
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

  public class UseExplicitNotation
	{
		public int? PlanetCount;
    
    public string GetSystemDescription()
		{
			if (PlanetCount.HasValue)
				return String.Format("System with {0} planets", PlanetCount);
			else
				return "We do not know how many planets are in this unexplored system.";
		}
	}

}
