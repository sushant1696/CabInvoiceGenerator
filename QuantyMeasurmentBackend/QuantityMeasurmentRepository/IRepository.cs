using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentRepository
{
    public interface IRepository
    {

        double FeetToInches(double feet);
        double InchToFeet(double inch);
        double CelsiusToFahranheit(double celsius);
        double FahranheitToCelsius(double fahranheit);
        Double KilogramToGramConverter(double kilogram);
        Double GramToKilogramConverter(double gram);
        double YardToFeetConverter(double yard);
        double YardToInchConverter(double yard);
    }
}
