using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assessment;

namespace Assessment.Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void AgeTest()
        {
            Car car = new Car(2020, "Honda", false);
            Assert.AreEqual(1, car.Age);
        }

        [TestMethod]
        public void ECheckTestUnderAge()
        {
            Car car = new Car(2019, "Honda", false);
            Assert.AreEqual(car.ECheck(2021), false);

        }

        [TestMethod]
        public void ECheckTestOverAge()
        {
            Car car = new Car(1950, "Honda", false);
            Assert.AreEqual(car.ECheck(2020), false);
        }

        [TestMethod]
        public void ECheckTestClassic()
        {
            Car car = new Car(2000, "Honda", true);
            Assert.AreEqual(car.ECheck(2021), false);
        }

        [TestMethod]
        public void ECheckTestEven()
        {
            Car car = new Car(2014, "Honda", false);
            Assert.AreEqual(car.ECheck(2020), true);

        }
        [TestMethod]
        public void ECheckTestOdd()
        {
            Car car = new Car(2013, "Honda", false);
            Assert.AreEqual(car.ECheck(2021), true);

        }

        [TestMethod]
        public void ECheckTest()
        {
            Car car = new Car(2012, "Honda", false);
            Assert.AreEqual(car.ECheck(2021), false);

        }
    }
}
