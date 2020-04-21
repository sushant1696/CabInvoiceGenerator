using System;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fahranheit.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Fahranheit
    {
        public double fahranheit;
        public Fahranheit(double fahranheit)
        {
           this.fahranheit = fahranheit;
        }
        public double GetFahranheitValue()
        {
            return this.fahranheit;
        }
    }
}
