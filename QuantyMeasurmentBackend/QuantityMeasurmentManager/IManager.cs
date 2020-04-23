// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace QuantityMeasurmentManager
{
    public interface IManager
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
