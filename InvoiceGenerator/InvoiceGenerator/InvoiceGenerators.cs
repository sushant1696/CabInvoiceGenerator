using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerator
{
    public class InvoiceGenerators
    {
        private double Per_Km_Cost = 10;
        private double Per_Km_Cost_premium = 15;
        private double Per_Minut_Cost = 1;
        private double Per_Minut_Cost_premium = 2;
        private double Minimum_Cost = 5;
        private double Minimum_Cost_premium = 20;
        double TotalFare;
        public double CalculateFare(string str, double dist, double time)
        {
            if (str == "Normal")
            {
                TotalFare = dist * Per_Km_Cost + Per_Minut_Cost * time;
                return Math.Max(TotalFare, Minimum_Cost);
            }
            TotalFare = dist * Per_Km_Cost_premium + Per_Minut_Cost_premium * time;
            return Math.Max(TotalFare, Minimum_Cost_premium);
        }

        /// <summary>
        /// It calculate the multi ride fare of cab
        /// return the total fare
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        public double CalculateMultiRideFare(string ride_type ,List<Ride> rides)
        {
            double TotalFr = 0;
            foreach (Ride ride in rides)
            {
                TotalFr += this.CalculateFare(ride_type ,ride.distance_in_km, ride.time_in_min);

            }

            return TotalFr;
        }
    }
}
