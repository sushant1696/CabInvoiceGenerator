using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerator
{
    public class InvoiceGenerators
    {
        private double Per_Km_Cost = 10;
        private double Per_Minut_Cost = 1;
        private double Minimum_Cost = 5;

        public double CalculateFare(double dist, double time)
        {
            double TotalFare = dist * Per_Km_Cost + Per_Minut_Cost * time;
            if (TotalFare < Minimum_Cost)
                return Minimum_Cost;
            return TotalFare;
        }

        /// <summary>
        /// It calculate the multi ride fare of cab
        /// return the total fare
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        public double CalculateMultiRideFare(List<Ride> rides)
        {
            double TotalFr = 0;
            foreach (Ride ride in rides)
            {
                TotalFr += this.CalculateFare(ride.distance_in_km, ride.time_in_min);

            }

            return TotalFr;
        }
    }
}
