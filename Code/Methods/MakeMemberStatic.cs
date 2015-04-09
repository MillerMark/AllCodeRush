using System;

namespace AllCodeRush.Code.Methods
{
	/* •———————————————————————————————————————————————————————•
			Feature: Make Member Static
        
			Use Case: Lets you make a member static and updates all 
			references accordingly.
         
			Available: When the cursor is on an instance member
			declaration that is free of any instance member 
      references.
        
			See also: Make Member Non-Static
		 •———————————————————————————————————————————————————————• */

	public class MakeMemberStatic
	{
    public double CalculateTorusVolume(double innerRadius, double outerRadius)
    {
      double totalRadius = innerRadius + outerRadius;
      double diameter = outerRadius - innerRadius;
      return totalRadius * Math.Pow(diameter * Math.PI, 2) / 4;
    }

		#region Additional
		// Note: The following function cannot be made static because it references an instance member
		private int instanceMember;
		public int MethodUsingInstanceMember()
		{
			return instanceMember;
		}
		#endregion
	}
}
