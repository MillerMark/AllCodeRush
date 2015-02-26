using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods.Parameters
{
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
