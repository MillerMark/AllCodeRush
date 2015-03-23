using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods.Parameters
{
	/* •———————————————————————————————————————————————————————•
			Feature: Introduce Parameter Object
        
			Use Case: Lets you consolidates selected parameters into 
			a single structure.
         
			Available: 
			 - When the caret is on a method declaration or call, 
			 with more than one parameter.
			 - When two or more parameters are selected in a method 
			 declaration or call.
        
			See also: Decompose Parameter
		 •———————————————————————————————————————————————————————• */

	public class IntroduceParameterObject
	{
		public void Foo()
		{
			ProcessPerson(new Customer("John", "Adams", "12345"));
		}
		private struct Customer
		{
			private string _forename;
			private string _surname;
			private string _tel;
			/// <summary>
			/// Summary for Customer
			/// </summary>
			public Customer(string Forename, string Surname, string Tel)
			{
				_forename = Forename;
				_surname = Surname;
				_tel = Tel;
			}
			public string Forename
			{
				get
				{
					return _forename;
				}
			}
			public string Surname
			{
				get
				{
					return _surname;
				}
			}
			public string Tel
			{
				get
				{
					return _tel;
				}
			}
		}

		#region Support
		private void ProcessPerson(Customer person)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
