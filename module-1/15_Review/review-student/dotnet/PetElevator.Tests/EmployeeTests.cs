using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PetElevator.HR;

namespace PetElevator.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void FullNameReturnsCorrectFormat()
        {
            Employee employee = new Employee("Test", "Testerson");

            string fullName = employee.FullName;

            Assert.AreEqual("Testerson, Test", fullName);
        }

        [TestMethod]
        public void RaiseSalaryTest_Positive()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(5); //raise 5%

            Assert.IsTrue(employee.Salary == 100 * 1.05);
        }

        [TestMethod]
        public void RaiseSalaryTest_Negative()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(-10); //"raise" by negative 10%

            Assert.AreEqual(100, employee.Salary); //salary should remain same
        }

        [TestMethod]
        public void GetBalanceDueEmployeeTest()
        {
            Employee employee = new Employee("Nicole", "Squish");

            Dictionary<string, double> servicesRendered = new Dictionary<string, double>()
            {

            };

            servicesRendered.Add("Grooming", 25);
            servicesRendered.Add("Walking", 50);
            servicesRendered.Add("Sitting", 100);

            double actual = employee.GetBalanceDue(servicesRendered);
            Assert.AreEqual(150, actual);

        }


    }
}
