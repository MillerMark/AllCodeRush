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
			ProcessPerson(new Person("Rory", "Becker", 37, "12345"));
		}
		private struct Person
		{
			private string _forename;
			private string _surname;
			private int _age;
			private string _tel;
			/// <summary>
			/// Summary for Person
			/// </summary>
			public Person(string Forename, string Surname, int Age, string Tel)
			{
				_forename = Forename;
				_surname = Surname;
				_age = Age;
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
			public int Age
			{
				get
				{
					return _age;
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
		private void ProcessPerson(Person person)
		{
			throw new NotImplementedException();
		}
	}
}
