using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerator
{
   public class Ride
    {
        /// Set and get value
        /// of distance_in_km by creating object
        /// </summary>
        public double distance_in_km { get; set; }
        /// <summary>
        /// Set and get value time_in_min by creating object
        /// </summary>
        public int time_in_min { get; set; }
        public Ride()
        {

        }
        public Ride(double distance_in_km,int time_in_min)
        {
            this.distance_in_km = distance_in_km;

            this.time_in_min = time_in_min;
        }
    }
}
