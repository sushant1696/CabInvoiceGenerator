﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerator
{
   public class RideRepository
    {
        Dictionary<string, List<Ride>> user_rides = new Dictionary<string, List<Ride>>();
        /// <summary>
        /// It the particular user ride
        /// with its id
        /// with its total rides .
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="rides"></param>
        public void Add_Rides(string user_id, List<Ride> rides)
        {
            user_rides.Add(user_id, rides);
        }

        /// <summary>
        /// It return the total ride of particular
        /// user rides.
        /// </summary>
        /// <param name="_user_id"></param>
        /// <returns></returns>
        public int Get_User_Rides(string _user_id)
        {
            foreach (var user_ride in user_rides)
            {
                if (_user_id == user_ride.Key)
                {
                    return user_ride.Value.Count;
                }
            }
            return default;
        }
    }
}
