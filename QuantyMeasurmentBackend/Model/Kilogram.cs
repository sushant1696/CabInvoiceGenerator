using System;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Kilogram.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Kilogram
    {
        public double kg;
        public Kilogram(double kg)
        {
            this.kg = kg;
        }
        public double GetKilogramValue()
        {
            return this.kg;
        }
    }
}
