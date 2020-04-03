using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
   public class Fahrenheit
    {
        public double fr;
        public Fahrenheit(double fr)
        {
            this.fr = fr;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            else
                return true;

        }
        public bool ConvertFahrenheitValue(Fahrenheit fr)
        {
            if (this.fr.Equals(fr.fr))
                return true;
            else
                return false;
        }
    }
}
