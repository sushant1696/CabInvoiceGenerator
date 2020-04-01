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
            double result = obj.CalculateFare(2, 2);
            int expect = 22;
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
            var actual = obj.CalculateMultiRideFare(list);
            double expect = 200;//expected result 12*10+55+10+15=200
            Assert.AreEqual(expect, actual);
        }
        /// <summary>
        /// Return total no of ride.
        /// </summary>
        [Test]
        public void GivenAllRides_ShouldReturn_Total_number_of_Ride()
        {
            List<Ride> l_rides = new List<Ride>();
            l_rides.Add(new Ride { distance_in_km = 25, time_in_min = 5 });
            l_rides.Add(new Ride { distance_in_km = 0, time_in_min = 56 });
            l_rides.Add(new Ride { distance_in_km = 20, time_in_min = 65 });
            l_rides.Add(new Ride { distance_in_km = 25, time_in_min = 0 });
            Assert.AreEqual(invoice_Summary.Get_All_Rides(l_rides), l_rides.Count());
        }
        /// <summary>
        ///  Return total fare
        /// </summary>
        [Test]
        public void Get_Total_Fare()
        {
            List<Ride> ls = new List<Ride> { new Ride { distance_in_km = 190, time_in_min = 0 }, new Ride { distance_in_km = 0, time_in_min = 55 } };
            Assert.AreEqual(1955.0, invoice_Summary.Total_fare(ls));
        }
    }
}