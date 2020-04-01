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
        
    }
}