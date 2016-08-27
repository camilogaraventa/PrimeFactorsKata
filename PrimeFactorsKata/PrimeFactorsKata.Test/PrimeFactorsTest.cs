using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PrimeFactorsKata.Test
{
    [TestClass]
    public class PrimeFactorsTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void TestOne()
        {
            CollectionAssert.AreEqual(this.List(), PrimeFactors.Generate(1));
        }

        [TestMethod]
        public void TestTwo()
        {
            CollectionAssert.AreEqual(this.List(2), PrimeFactors.Generate(2));
        }

        [TestMethod]
        public void TestThree()
        {
            CollectionAssert.AreEqual(this.List(3), PrimeFactors.Generate(3));
        }

        [TestMethod]
        public void TestFour()
        {
            CollectionAssert.AreEqual(this.List(2, 2), PrimeFactors.Generate(4));
        }

        [TestMethod]
        public void TestFive()
        {
            CollectionAssert.AreEqual(this.List(5), PrimeFactors.Generate(5));
        }

        [TestMethod]
        public void TestSix()
        {
            CollectionAssert.AreEqual(this.List(2, 3), PrimeFactors.Generate(6));
        }

        [TestMethod]
        public void TestSeven()
        {
            CollectionAssert.AreEqual(this.List(7), PrimeFactors.Generate(7));
        }

        [TestMethod]
        public void TestEight()
        {
            CollectionAssert.AreEqual(this.List(2, 2, 2), PrimeFactors.Generate(8));
        }

        [TestMethod]
        public void TestNine()
        {
            CollectionAssert.AreEqual(this.List(3, 3), PrimeFactors.Generate(9));
        }

        [TestMethod]
        public void TestTwentyOne()
        {
            CollectionAssert.AreEqual(this.List(3, 7), PrimeFactors.Generate(21));
        }

        [TestMethod]
        public void TestSixteen()
        {
            CollectionAssert.AreEqual(this.List(2, 2, 2, 2), PrimeFactors.Generate(16));
        }

        private List<Int32> List(params Int32[] numbers)
        {
            List<Int32> list =  new List<Int32>();
            foreach(Int32 number in numbers)
            {
                list.Add(number);
            }
            return list;
        }
    }
}
