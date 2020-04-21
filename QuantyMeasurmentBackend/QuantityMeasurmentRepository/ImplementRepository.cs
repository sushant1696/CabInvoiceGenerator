using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentRepository
{
    public class ImplementRepository : IRepository
    {
        /// <summary>
        /// Implemeted method for converting feet to inch
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public double FeetToInches(double feet)
        {
            
            return feet*12;
        }

      
      
    }
}
