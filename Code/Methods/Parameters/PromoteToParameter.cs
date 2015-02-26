using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods.Parameters
{
    public class PromoteToParameter
    {
        public void main()
        {
            Log("Starting Application");
            try
            {
                throw new Exception("Bad things happened");
            }
            catch (Exception ex)
            {
                Log(String.Format("Something went very wrong:{0}", ex.Message));
            }
            Log("Ending Application");
        }

        public void Log(string Message)
        {
            Console.WriteLine("Error" + Message);
        }
    }
}
