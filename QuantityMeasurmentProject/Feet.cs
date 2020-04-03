using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentProject
{
    /// <summary>
    /// Creat a Feet.cs class to test equal,null,ref,and type of feet.
    /// </summary>
    public class Feet
    {
        public double feet;
        public Feet(double feet)
        {
            this.feet = feet;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            else
                return true;

        }
        public bool ConvertFeetValue(Feet feet)
        {
            if (this.feet.Equals(feet.feet))
                return true;
            else
                return false;
        }
    }
}
