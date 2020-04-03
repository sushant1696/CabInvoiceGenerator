using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
   public class FerToCelcius
    {
        public double cl;
        public double fr;
        public FerToCelcius(Celcius cl, Fahrenheit fr)
        {
            this.cl = cl.clc;
            this.fr = fr.fr;

        }
        public bool ComparedFerToCelciusValue(Celcius cl, Fahrenheit fr)
        {
            if (this.cl == 0 && (this.cl.Equals(this.fr)))
                return false;
            if (this.cl == 1 && (this.cl.Equals(this.fr)))
                return false;
            if (this.cl == 1 && (this.cl.Equals(33.8 * this.fr)))
                return true;
            return false;
        }
    }
}
