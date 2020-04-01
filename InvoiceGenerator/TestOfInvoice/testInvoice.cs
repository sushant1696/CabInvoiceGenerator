// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InvoiceGenerator" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------------
using InvoiceGenerator;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TestOfInvoice
{
    public class Tests
    {
       
        RideRepository riderepo = new RideRepository();
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
           
            List<Ride> listrides = new List<Ride>();
            listrides.Add(new Ride { distance_in_km = 25, time_in_min = 5 });
            listrides.Add(new Ride { distance_in_km = 0, time_in_min = 56 });
            listrides.Add(new Ride { distance_in_km = 20, time_in_min = 65 });
            listrides.Add(new Ride { distance_in_km = 25, time_in_min = 0 });
            InvoiceSummary ob = new InvoiceSummary();
            Assert.AreEqual(ob.Get_All_Rides(listrides), listrides.Count());
        }
        /// <summary>
        ///  Return total fare
        /// </summary>
        [Test]
        public void Get_Total_Fare()
        {
            List<Ride> ls = new List<Ride> { new Ride { distance_in_km = 190, time_in_min = 0 }, new Ride { distance_in_km = 0, time_in_min = 55 } };
            InvoiceSummary objj = new InvoiceSummary();
            Assert.AreEqual(1955.0, objj.Total_fare(ls));
        }
        /// <summary>
        /// Return Everage fare.
        /// </summary>
        [Test]
        public void GivenGet_Average_fare()
        {
            List<Ride> list_rides = new List<Ride>();
            list_rides.Add(new Ride { distance_in_km = 55, time_in_min = 85 });
            list_rides.Add(new Ride { distance_in_km = 0, time_in_min = 95 });
            list_rides.Add(new Ride { distance_in_km = 755, time_in_min = 0 });
            InvoiceSummary objjj = new InvoiceSummary();
            Assert.AreEqual(2760.0, objjj.Average_fare_per_ride(list_rides));
        }

        [Test]
        public void Get_User_Rides_Count_by_User_Id()
        {
            List<Ride> list_rides = new List<Ride>();
            list_rides.Add(new Ride { distance_in_km = 55, time_in_min = 85 });
            list_rides.Add(new Ride { distance_in_km = 0, time_in_min = 95 });
            list_rides.Add(new Ride { distance_in_km = 755, time_in_min = 0 });
            riderepo.Add_Rides("12345", list_rides);
            Assert.AreEqual(3, riderepo.Get_User_Rides("12345"));
        }
    }
}