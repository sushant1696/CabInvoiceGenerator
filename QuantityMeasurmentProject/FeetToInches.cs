using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
    public class FeetToInches
    {
        public double feet;
        public double inch;
        public FeetToInches(Feet feet, Inches inch)
        {
            feet.feet = this.feet;
            inch.inch = this.inch;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="feet"></param>
        /// <param name="inch"></param>
        /// <returns></returns>
        public bool ComparedFeetAndinchesValue(Feet feet, Inches inch)
        {
            if (feet.feet == 0 && feet.feet == inch.inch)
                return true;
            if (feet.feet == 1 && feet.feet == inch.inch)
                return false;
            if (feet.feet == 1 && inch.inch == 12)
                return true;
            return false;
        }
    }
}
