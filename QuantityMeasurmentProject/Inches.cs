// --------------------------------------------------------------------------------------------------------------------
// <copyright file=QualityMeasurment" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{

    public class Inches
    {
        public double inch;
        public Inches(double inch)
        {
            this.inch = inch;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            else
                return true;

        }
        public bool ConvertInchValue(Inches inch)
        {
            if (this.inch.Equals(inch.inch))
                return true;
            else
                return false;
        }
    }
}
