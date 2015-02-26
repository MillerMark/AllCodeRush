using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods.Parameters
{
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
