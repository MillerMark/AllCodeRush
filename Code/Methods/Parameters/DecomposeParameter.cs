using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods.Parameters
{
	/* •———————————————————————————————————————————————————————•
			Feature: Decompose Parameter
        
			Use Case: Lets you replace a single parameter with one or 
			more new parameters, each representing a property accessed 
			in the original parameter. And appropriately changes all 
			method references.
         
			Available:  
			 - When the caret is on a parameter declaration. The 
			 parameter should be a complex-type.
			 - When the caret is on a reference to a property of a 
			 complex-type parameter.
        
			See also: Introduce Parameter Object
		 •———————————————————————————————————————————————————————• */

	public class DecomposeParameter
	{
		private void DisplayNames()
		{
			Person p1 = new Person() { Name = "Rory", Age = 37, Tel = "12345" };
			Person p2 = new Person() { Name = "Bob", Age = 22, Tel = "54321" };
			DisplayName(p1);
			DisplayName(p2);
		}

		private void DisplayName(AllCodeRush.Code.Methods.Parameters.Person person)
		{
			Console.WriteLine("The name of this person is {0}", person.Name);
		}
	}
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string Tel { get; set; }
	}
}
