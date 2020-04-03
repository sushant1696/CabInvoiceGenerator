using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
    public class Gram
    {
        public double grm;
        public Gram(double grm)
        {
            this.grm = grm;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            else
                return true;

        }
        public bool ConvertGramValue(Gram grm)
        {
            if (this.grm.Equals(grm.grm))
                return true;
            else
                return false;
        }
    }
}
