using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{

    [TestClass]
    public class AnimalGroupTests
    {
        [TestMethod]
        public void LowercaseTest()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string actual = animalGroupName.GetHerd("giraffe");

            Assert.AreEqual("Tower", actual);

        }

        [TestMethod]
        public void NullTest()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string actual = animalGroupName.GetHerd("");

            Assert.AreEqual("unknown", actual);

        }

        [TestMethod]
        public void AnimalNotInList()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string actual = animalGroupName.GetHerd("walrus");

            Assert.AreEqual("unknown", actual);

        }

        [TestMethod]
        public void CaptialTest()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string actual = animalGroupName.GetHerd("RHINO");

            Assert.AreEqual("Crash", actual);

        }

        [TestMethod]
        public void PluralTest()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();

            string actual = animalGroupName.GetHerd("elephants");

            Assert.AreEqual("unknown", actual);

        }

    }


    [TestClass]
    public class CigarPartyTests
    {

        [TestMethod]
        public void NoPartyTest()
        {
            CigarParty cigarParty = new CigarParty();

            bool actual = cigarParty.HaveParty(30, false);

            Assert.AreEqual(false, actual);

        }

        [TestMethod]
        public void HavePartyTest1()
        {
            CigarParty cigarParty = new CigarParty();

            bool actual = cigarParty.HaveParty(50, true);

            Assert.AreEqual(true, actual);

        }

        [TestMethod]
        public void HavePartyTest2()
        {
            CigarParty cigarParty = new CigarParty();

            bool actual = cigarParty.HaveParty(70, true);

            Assert.AreEqual(true, actual);

        }

    }

    [TestClass]
    public class DateFashionTests
    {

        [TestMethod]
        public void YesTableTest()
        {
            DateFashion dateFashion = new DateFashion();

            int actual = dateFashion.GetATable(5, 10);

            Assert.AreEqual(2, actual);

        }

        [TestMethod]
        public void NoTableTest()
        {
            DateFashion dateFashion = new DateFashion();

            int actual = dateFashion.GetATable(5, 2);

            Assert.AreEqual(0, actual);

        }

        [TestMethod]
        public void MaybeTableTest()
        {
            DateFashion dateFashion = new DateFashion();

            int actual = dateFashion.GetATable(5, 5);

            Assert.AreEqual(1, actual);

        }

    }

    [TestClass]
    public class FrontTimesTests
    {

        [TestMethod]
        public void FrontTimesTest1()
        {
            FrontTimes frontTimes = new FrontTimes();

            string actual = frontTimes.GenerateString("Chocolate", 2);

            Assert.AreEqual("ChoCho", actual);

        }

        [TestMethod]
        public void FrontTimesTest2()
        {
            FrontTimes frontTimes = new FrontTimes();

            string actual = frontTimes.GenerateString("Chocolate", 3);

            Assert.AreEqual("ChoChoCho", actual);

        }

        [TestMethod]
        public void FrontTimesTest3()
        {
            FrontTimes frontTimes = new FrontTimes();

            string actual = frontTimes.GenerateString("Abc", 3);

            Assert.AreEqual("AbcAbcAbc", actual);

        }


    }

    [TestClass]
    public class Less20Tests
    {

        [TestMethod]
        public void Less20Test1()
        {
            Less20 less20 = new Less20();

            bool actual = less20.IsLessThanMultipleOf20(18);

            Assert.AreEqual(true, actual);

        }

        [TestMethod]
        public void Less20Test2()
        {
            Less20 less20 = new Less20();

            bool actual = less20.IsLessThanMultipleOf20(19);

            Assert.AreEqual(true, actual);

        }

        [TestMethod]
        public void Less20Test3()
        {
            Less20 less20 = new Less20();

            bool actual = less20.IsLessThanMultipleOf20(20);

            Assert.AreEqual(false, actual);

        }



    }
}

