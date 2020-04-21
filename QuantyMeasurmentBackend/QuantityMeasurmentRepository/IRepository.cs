using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentRepository
{
    public interface IRepository
    {

        double FeetToInches(double feet);
        //Fahranheit CelsiusToFahrenheitConverter(Celcius celsius);
        //    Celcius FahrenheitToCelsiusCoverter(Fahranheit fahranheit);
        //    Gram KilogramToGramConverter(Kilogram kilogram);
        //    Kilogram GramToKilogramConverter(Gram gram);
           
        //    Feet InchToFeetConverter(Inches inch);
        //    Feet YardToFeetConverter(Yard yard);
        //    Inches YardToInchConverter(Yard yard);
    }
}
