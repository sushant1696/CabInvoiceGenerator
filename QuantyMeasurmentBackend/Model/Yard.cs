using System;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Yard.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Yard
    {
        public double yard;
        public Yard(double yard)
        {
            this.yard = yard;
        }
        public double GetYardValue()
        {
            return this.yard;
        }
    }
}
