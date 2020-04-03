using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
   public class Kilogram
    {
        public double klgm;
        public Kilogram(double klgm)
        {
            this.klgm = klgm;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            else
                return true;

        }
        public bool ConvertFeetValue(Kilogram klgm)
        {
            if (this.klgm.Equals(klgm.klgm))
                return true;
            else
                return false;
        }
    }
}
