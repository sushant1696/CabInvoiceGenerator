// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InvoiceGenerator" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------------
using InvoiceGenerator;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestOfInvoice
{
    public class Tests
    {
        
        [Test]
        public void GivenDistanceAndTime_whereShouldReturnTotalFare()
        {
            InvoiceGenerators obj = new InvoiceGenerators();
            double result = obj.CalculateFare(3, 2);
            int expect = 32;
            Assert.AreEqual(expect, result);
        }
        /// <summary>
        /// Step 2 GivenMultiRide_ShouldReturnTotalFare
        /// </summary>
        [Test]
        public void GivenMultiRide_ShouldReturnTotalFare()
        {
            //It creates the List for multi ride .
            List<Ride> list = new List<Ride> {
                new Ride { distance_in_km = 12, time_in_min = 0 },
                new Ride { distance_in_km = 0, time_in_min = 55 },
                new Ride { distance_in_km = 0, time_in_min = 10 },
                 new Ride { distance_in_km = 0, time_in_min = 15 }
            };
            InvoiceGenerators obj = new InvoiceGenerators();
            var actual =obj.CalculateMultiRideFare(list);
            double expect = 200;//expected result 12*10+55+10+15=200
            Assert.AreEqual(expect, actual);
        }
    }
}