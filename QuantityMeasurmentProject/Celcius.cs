using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
  public  class Celcius
    {
        public double clc;
        public Celcius(double clc)
        {
            this.clc = clc;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            else
                return true;

        }
        public bool ConvertCelciusValue(Celcius clc)
        {
            if (this.clc.Equals(clc.clc))
                return true;
            else
                return false;
        }
    }
}
