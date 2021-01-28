﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class StringExercisesTests
    {
        //Assert
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()

        [TestMethod]
        public void MakeAbbaTest()
        {
            // Arrange Act Assert

            StringExercises stringExercises = new StringExercises();

            string actual = stringExercises.MakeAbba("Hi", "Bye");

            Assert.AreEqual("HiByeByeHi", actual);




        }


    }
}