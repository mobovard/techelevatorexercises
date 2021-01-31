using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.CRM;

namespace PetElevator.Tests
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void ListVaccinationsTest()
        {
            Pet pet = new Pet("Luna", "cat");
            pet.Vaccinations = new List<string>()
            {
                "Rabies",
                "Distemper",
                "Parvo"
            };

            Assert.AreEqual("Rabies, Distemper, Parvo", pet.ListVaccinations());
        }


    }
}
