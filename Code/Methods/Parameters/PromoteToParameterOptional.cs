using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods.Parameters
{
    public class PromoteToParameterOptional
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

            //TODO: Why is this refactoring not availble here?
            Console.WriteLine("Error" + Message);

            // But works fine here.
            string LogType = "Error";
            Console.WriteLine(LogType + Message);


        }
    }
}
