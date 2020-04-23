using Model;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImplementManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentRepository
{
    public interface IRepository
    {
     
        double CelsiusToFahranheit(double celsius);
        double FahranheitToCelsius(double fahranheit);
        double FeetToInches(double feet);
        double InchToFeet(double inch);
        Double KilogramToGramConverter(double kilogram);
        Double GramToKilogramConverter(double gram);
        double YardToFeetConverter(double yard);
        double YardToInchConverter(double yard);
    }
}
