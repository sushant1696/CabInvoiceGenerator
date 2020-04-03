using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
    public class KilogramToGram
    {

        public double klgm;
        public double gram;
        public KilogramToGram(Kilogram klgm, Gram gram)
        {
            this.klgm = klgm.klgm;
            this.gram = gram.grm;

        }
        public bool ComparedKilogramAndGramValue(Kilogram klg, Gram grrm)
        {
            if (this.klgm == 0 && (this.klgm.Equals(this.gram)))
                return true;
            if (this.klgm == 1 && (this.klgm.Equals(this.gram)))
                return false;
            if (this.gram == 1 && (this.klgm.Equals(1000 * this.gram)))
                return true;
            return false;
        }
    }

}
