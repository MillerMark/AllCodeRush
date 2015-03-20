using System;
using System.Collections.Generic;

namespace AllCodeRush.Code.EventsDelegates
{
  /* •———————————————————————————————————————————————————————•
      Feature: Declare Delegate
        
      Use Case: Declares the delegate at the caret.
         
      Available: When the caret is on an undeclared delegate.
        
      See also: Compress to Lambda Expression, Expand Lambda 
      Expression
     •———————————————————————————————————————————————————————• */

  public class DeclareDelegate
  {
    List<Employee> employees = new List<Employee> {
               new Employee { ID = 1, Role = 1, LastName = "Smith", FirstName = "Sally"},
               new Employee { ID = 2, Role = 2, LastName = "Jones", FirstName = "John"}
            };

    private Employee FindEmployee(int idToMatch)
    {
      EmployeeFilter filter = delegate(Employee employee)
                              {
                                return employee.ID == idToMatch;
                              };

      // Find employee...
      Employee foundEmployee = null;
      foreach (Employee employee in employees)
        if (filter(employee))
          foundEmployee = employee;

      if (foundEmployee != null)
        return foundEmployee;

      return null;
    }
  }
}
