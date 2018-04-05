using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Helpers
{
    public static class StringValidationExtension
    {
        public static bool stringChecker(this string str)
        {
            if(string.IsNullOrEmpty(str))
                 throw new Exception("String cannot be empty");
            else return true;
        }

        public static bool naturalNumberChecker(this string str)
        {
            Int64 longInput;
            try
            {
                longInput = Convert.ToInt64(str);
            }
            catch
            {
                throw new Exception("Invalid input, please make sure to enter a natural number.");
            }
            if (longInput <= 0)
                throw new Exception("Invalid input, the input cannot be negative or zero.");

            return true;
        }
    }
}
