using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentRepository
{
    public class ImplementRepository : IRepository
    {
        public double CelsiusToFahranheit(double celsius)
        {
            return ((9 / 5) * celsius + 32);
        }

        public double FahranheitToCelsius(double fahranheit)
        {
            return (fahranheit - 32) * 5 / 9;
        }

        /// <summary>
        /// Implemeted method for converting feet to inch
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public double FeetToInches(double feet)
        {
            
            return feet*12;
        }

        public double GramToKilogramConverter(double gram)
        {
            return gram / 1000;
        }

        /// <summary>
        /// Implemeted method for converting  inch to feet
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public double InchToFeet(double inch)
        {
            return inch/12;
        }

        public double KilogramToGramConverter(double kilogram)
        {
            return kilogram*1000;
        }

        public double YardToFeetConverter(double yard)
        {
            return yard * 3;
        }

        public double YardToInchConverter(double yard)
        {
            return yard * 36;
        }
    }
}
