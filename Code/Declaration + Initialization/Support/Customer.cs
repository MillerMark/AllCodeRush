using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
  public class Customer
  {
    private readonly string _forename;
    private readonly string _surname;
    private readonly int _age;
    private DateTime _dateOfBirthApprox;
    public Customer(string forename, string surname, int age)
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
