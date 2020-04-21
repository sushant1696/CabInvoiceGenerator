
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feet.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Feet
    {

        public double feet;
        public Feet(double feet)
        {
            this.feet = feet;
        }
        public double GetFeetValue()
        {
            return this.feet;
        }
    
}
}
