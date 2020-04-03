using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
   public class FeedToYard
    {
        public double feet;
        public double yard;
        public FeedToYard(Feet feet, Yard yard)
        {
            feet.feet = this.feet;
            yard.yrd = this.yard;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="feet"></param>
        /// <param name="inch"></param>
        /// <returns></returns>
        public bool ComparedFeetToYardValue(Feet feet, Yard yard)
        {
            if (yard.yrd == 0 && feet.feet == yard.yrd)
                return true;
            if (feet.feet == 3 && feet.feet == yard.yrd)
                return false;
            if (feet.feet == 1 && yard.yrd == 3)
                return true;
            return false;
        }
    }
}
