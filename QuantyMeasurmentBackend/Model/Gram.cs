using System;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gram.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Gram
    {
        public double gram;
        public Gram(double gram)
        {
            this.gram = gram;
        }
        public double GetGramValue()
        {
            return this.gram;
        }
    }
}
