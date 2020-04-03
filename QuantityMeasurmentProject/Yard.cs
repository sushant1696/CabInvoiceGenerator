using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
    public class Yard
    {
        public double yrd;
        public Yard(double yrd)
        {
            this.yrd = yrd;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            else
                return true;

        }
        public bool ConvertYardValue(Yard yrd)
        {
            if (this.yrd.Equals(yrd.yrd))
                return true;
            else
                return false;
        }
    }
}
