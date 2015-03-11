using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
  public class CustomAttribute : Attribute
  {
    public CustomAttribute()
    {
      
    }
    public string Name { get; set; }
    public int Count { get; set; }
  }
}
