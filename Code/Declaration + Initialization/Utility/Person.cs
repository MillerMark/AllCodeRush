using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
    public class Person
    {
        private readonly string _forename;
        private readonly string _surname;
        private readonly int _age;
        private DateTime _dateOfBirthApprox;
        public Person(string forename, string surname, int age)
        {
            _forename = forename;
            _surname = surname;
            _age = age;
        }

        public DateTime DateOfBirthApprox
        {
            get { return _dateOfBirthApprox = DateTime.UtcNow.AddYears(-1 * _age); }
        }
    }
}
