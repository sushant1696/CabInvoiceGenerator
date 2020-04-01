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

    }
}
