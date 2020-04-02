using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
    public class Inches
    {
        int inch;
        public Inches(int feet)
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
        public bool ConvertInchValue(Feet inch)
        {
            if (this.inch.Equals(inch))
                return true;
            else
                return false;
        }
    }
}
