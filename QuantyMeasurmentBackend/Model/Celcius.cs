// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Celsius.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Celcius
    {
        public double celcius;
        public Celcius(double celcius)
        {
            this.celcius = celcius;
        }
        public double GetCelciusValue()
        {
            return this.celcius;
        }
    }
}
