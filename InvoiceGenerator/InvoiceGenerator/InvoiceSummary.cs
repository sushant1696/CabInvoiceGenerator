using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerator
{
   public class InvoiceSummary
    {
        InvoiceGenerators calfare = new InvoiceGenerators();
        /// <summary>
        /// It return the total ride
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        public int Get_All_Rides(List<Ride> rides)
        {
            return rides.Count;
        }
        /// <summary>
        /// It return the total fare
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        public  double Total_fare(string ride_type , List<Ride> rides)
           
        {
            return calfare.CalculateMultiRideFare(ride_type,rides);
        }
        /// <summary>
        /// It return the total 
        /// Average fare
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        public double Average_fare_per_ride(string ride_type, List<Ride> rides)
        {
            return (calfare.CalculateMultiRideFare(ride_type, rides) / (rides.Count) );
        }
    }
}
