using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.Shared;

namespace PetElevator.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void GetBalanceDueCustomerTest()
        {
            Customer customer = new Customer("Nicole", "Squish");

            Dictionary<string, double> servicesRendered = new Dictionary<string, double>()
            {

            };

            servicesRendered.Add("Grooming", 25);
            servicesRendered.Add("Walking", 50);
            servicesRendered.Add("Sitting", 100);

            double actual = customer.GetBalanceDue(servicesRendered);
            Assert.AreEqual(175, actual);

        }


    }
}
