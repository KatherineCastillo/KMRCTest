using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMRC.Temperatura
{
    public class Calculator
    {
        public double CelsiusFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public double FahrenheititToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
