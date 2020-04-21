using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentRepository
{
    public class ImplementRepository : IRepository
    {
        /// <summary>
        /// Implemented method of Gram To Kilogram Converter
        /// </summary>
        /// <param name="gram"></param>
        /// <returns></returns>
        public Kilogram GramToKilogramConverter(Gram gram)
        {
            /// 1kg= 1000 gram
            var kg = gram.GetGramValue() / 1000;
            Kilogram kilogram = new Kilogram(kg);
            return kilogram;
        }
        /// <summary>
        /// Implemented method for converting kg to gram
        /// </summary>
        /// <param name="kilogram"></param>
        /// <returns></returns>
        public Gram KilogramToGramConverter(Kilogram kilogram)
        {
            /// 1000 gram=1kg
            var gramFormula = kilogram.GetKilogramValue() * 1000;
            Gram gram = new Gram(gramFormula);
            return gram;
        }
        /// <summary>
        /// Implemented mathod to convert yard to feet
        /// 
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public Feet YardToFeetConverter(Yard yard)
        {
            /// 1 yard=3 feet
            var oneYard = yard.GetYardValue() * 3;
            var feetValue = new Feet(oneYard);
            return feetValue;
        }
        /// <summary>
        /// Implemented method to convart yard to inch
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public Inches YardToInchConverter(Yard yard)
        {

            var Inch = yard.GetYardValue() * 36;
            Inches inches = new Inches(Inch);
            return inches;
        }
        /// <summary>
        /// Implemented method to convert inch to feet
        /// </summary>
        /// <param name="inch"></param>
        /// <returns></returns>
        public Feet InchToFeetConverter(Inches inch)
        {
            var inchValue = inch.GetInchesValue() / 12;
            Feet feet = new Feet(inchValue);
            return feet;
        }
        /// <summary>
        /// Implemented method for converting Celsius To Fahrenheit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public Fahranheit CelsiusToFahrenheitConverter(Celcius celcius)
        {
            var fahrenheitValue = (celcius.GetCelciusValue() + 32) * 9 / 5;
            Fahranheit fahranheit = new Fahranheit(fahrenheitValue);
            return fahranheit;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fahranheit"></param>
        /// <returns></returns>
        public Celcius FahrenheitToCelsiusCoverter(Fahranheit fahranheit)
        {
            var celsiusValue = (fahranheit.GetFahranheitValue() - 32) * 5 / 9;
            Celcius celcius = new Celcius(celsiusValue);
            return celcius;
        }
        /// <summary>
        /// Implemeted method for converting feet to inch
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public Inches FeetToInchConverter(Feet feet)
        {
            var feetToInchValue = feet.GetFeetValue() * 12;
            Inches inchValue = new Inches(feetToInchValue);
            return inchValue;
        }

    }
}
