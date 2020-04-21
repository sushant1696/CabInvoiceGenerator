using System;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inches.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Inches
    {

        public double inch;
        public Inches(double inch)
        {
            this.inch = inch;
        }
        public double GetInchesValue()
        {
            return this.inch;
        }
    }
}
