using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

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
        public void FrontTimesTestCho2()
        {
            FrontTimes frontTimes = new FrontTimes();

            string actual = frontTimes.GenerateString("Chocolate", 2);

            Assert.AreEqual("ChoCho", actual);

        }

        [TestMethod]
        public void FrontTimesTestCho3()
        {
            FrontTimes frontTimes = new FrontTimes();

            string actual = frontTimes.GenerateString("Chocolate", 3);

            Assert.AreEqual("ChoChoCho", actual);

        }

        [TestMethod]
        public void FrontTimesTestAbc3()
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
        public void Less20Test18()
        {
            Less20 less20 = new Less20();

            bool actual = less20.IsLessThanMultipleOf20(18);

            Assert.AreEqual(true, actual);

        }

        [TestMethod]
        public void Less20Test19()
        {
            Less20 less20 = new Less20();

            bool actual = less20.IsLessThanMultipleOf20(19);

            Assert.AreEqual(true, actual);

        }

        [TestMethod]
        public void Less20Test20()
        {
            Less20 less20 = new Less20();

            bool actual = less20.IsLessThanMultipleOf20(20);

            Assert.AreEqual(false, actual);

        }



    }

    [TestClass]
    public class Lucky13Tests
    {

        [TestMethod]
        public void Lucky13TestIsLucky()
        {
            int[] input = { 0, 2, 4 };
            Lucky13 lucky13 = new Lucky13();

            bool actual = lucky13.GetLucky(input);

            Assert.AreEqual(true, actual);

        }

        [TestMethod]
        public void Lucky13TestNotLucky1()
        {
            int[] input = { 1, 2, 3 };
            Lucky13 lucky13 = new Lucky13();

            bool actual = lucky13.GetLucky(input);

            Assert.AreEqual(false, actual);

        }

        [TestMethod]
        public void Lucky13TestNotLucky2()
        {
            int[] input = { 1, 2, 4 };
            Lucky13 lucky13 = new Lucky13();

            bool actual = lucky13.GetLucky(input);

            Assert.AreEqual(false, actual);

        }
    }

    [TestClass]
    public class MaxEnd3Tests
    {

        [TestMethod]
        public void MaxEndTest1()
        {
            int[] input = { 1, 2, 3 };
            MaxEnd3 maxEnd3 = new MaxEnd3();

            int[] actual = maxEnd3.MakeArray(input);

            int[] expected = { 3, 3, 3 };
            Assert.AreEqual(true, actual.SequenceEqual(expected));

        }

        [TestMethod]
        public void MaxEndTest2()
        {
            int[] input = { 11, 5, 9 };
            MaxEnd3 maxEnd3 = new MaxEnd3();

            int[] actual = maxEnd3.MakeArray(input);

            int[] expected = { 11, 11, 11 };
            Assert.AreEqual(true, actual.SequenceEqual(expected));

        }

        [TestMethod]
        public void MaxEndTest3()
        {
            int[] input = { 2, 11, 3 };
            MaxEnd3 maxEnd3 = new MaxEnd3();

            int[] actual = maxEnd3.MakeArray(input);

            int[] expected = { 3, 3, 3 };
            Assert.AreEqual(true, actual.SequenceEqual(expected));

        }
    }

    [TestClass]
    public class NonStartTests
    {

        [TestMethod]
        public void NonstartTest1()
        {
            NonStart nonStart = new NonStart();

            string actual = nonStart.GetPartialString("Hello", "There");

            Assert.AreEqual("ellohere", actual);

        }

        [TestMethod]
        public void NonstartTest2()
        {
            NonStart nonStart = new NonStart();

            string actual = nonStart.GetPartialString("java", "code");

            Assert.AreEqual("avaode", actual);

        }

        [TestMethod]
        public void NonstartTest3()
        {
            NonStart nonStart = new NonStart();

            string actual = nonStart.GetPartialString("shotl", "java");

            Assert.AreEqual("hotlava", actual);

        }

    }

    [TestClass]
    public class SameFirstLastTests
    {

      
        [TestMethod]
        public void SameFirstLastTest1()
        {
            int[] input = { 1, 2, 3 };
            SameFirstLast sameFirstLast = new SameFirstLast();

            bool actual = sameFirstLast.IsItTheSame(input);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void SameFirstLastTest2()
        {
            int[] input = { 1, 2, 3, 1 };
            SameFirstLast sameFirstLast = new SameFirstLast();

            bool actual = sameFirstLast.IsItTheSame(input);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SameFirstLastTest3()
        {
            int[] input = { 1, 2, 1 };
            SameFirstLast sameFirstLast = new SameFirstLast();

            bool actual = sameFirstLast.IsItTheSame(input);

            Assert.AreEqual(true, actual);
        }

    }

    [TestClass]
    public class StringBitsTests
    {
       
        [TestMethod]
        public void StringBitsTestHello()
        {
            StringBits stringBits = new StringBits();

            string actual = stringBits.GetBits("Hello");

            Assert.AreEqual("Hlo" , actual);
        }

        [TestMethod]
        public void StringBitsTestHi()
        {
            StringBits stringBits = new StringBits();

            string actual = stringBits.GetBits("Hi");

            Assert.AreEqual("H", actual);
        }
        [TestMethod]
        public void StringBitsTestHeeololeo()
        {
            StringBits stringBits = new StringBits();

            string actual = stringBits.GetBits("Heeololeo");

            Assert.AreEqual("Hello", actual);
        }

    }

    [TestClass]
    public class WordCountTest
    {

        [TestMethod]
        public void WordCountTestBlackSheep()
        {
            WordCount wordCount = new WordCount();
            string[] input = {"ba", "ba", "black", "sheep" };
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"ba", 2 },
                {"black", 1 },
                {"sheep", 1 }
            };

            Dictionary<string, int> actual = wordCount.GetCount(input);

            foreach (KeyValuePair<string, int> keyValPair in expected)
            {
                if (!actual.ContainsKey(keyValPair.Key))
                {
                    Assert.Fail();
                }
                Assert.AreEqual(keyValPair.Value, actual[keyValPair.Key]);
            }
        }

        [TestMethod]
        public void WordCountTestABC()
        {
            WordCount wordCount = new WordCount();
            string[] input = { "a", "b", "a", "c", "b" };
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"a", 2 },
                {"b", 2 },
                {"c", 1 }
            };

            Dictionary<string, int> actual = wordCount.GetCount(input);

            foreach (KeyValuePair<string, int> keyValPair in expected)
            {
                if (!actual.ContainsKey(keyValPair.Key))
                {
                    Assert.Fail();
                }
                Assert.AreEqual(keyValPair.Value, actual[keyValPair.Key]);
            }
        }
        [TestMethod]
        public void WordCountTestEmpty()
        {
            WordCount wordCount = new WordCount();
            string[] input = {};
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {

            };

            Dictionary<string, int> actual = wordCount.GetCount(input);

            foreach (KeyValuePair<string, int> keyValPair in expected)
            {
                if (!actual.ContainsKey(keyValPair.Key))
                {
                    Assert.Fail();
                }
                Assert.AreEqual(keyValPair.Value, actual[keyValPair.Key]);
            }
        }

        public void WordCountTestCBA()
        {
            WordCount wordCount = new WordCount();
            string[] input = { "c", "b", "a" };
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"c", 3 },
                {"b", 2 },
                {"a", 1 }
            };

            Dictionary<string, int> actual = wordCount.GetCount(input);

            foreach (KeyValuePair<string, int> keyValPair in expected)
            {
                if (!actual.ContainsKey(keyValPair.Key))
                {
                        Assert.Fail();
                }
                Assert.AreEqual(keyValPair.Value, actual[keyValPair.Key]);
            }
        }
       
    }

}

