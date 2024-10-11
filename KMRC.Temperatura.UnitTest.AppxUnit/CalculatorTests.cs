using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMRC.Temperatura.UnitTest.AppxUnit
{
    public class CalculatorTests
    {
        
        public string ReverseString(string input)
        {
            if (input == null) return null;
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);

        }
        public string RemoveSpace(string input)
        {
            return input.Replace(" ", " ");
        }
    }
}
