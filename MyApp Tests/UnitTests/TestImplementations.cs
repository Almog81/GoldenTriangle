using System;
using NUnit.Framework;
using MyApp.Utilities;
using MyApp;

namespace MyApp_Tests.UnitTests
{
    [TestFixture]
    public class TestImplementations
    {
        [Test]
        public void Test01_ReverseNumbersPositive() //TC-07
        {
            int expected = 54321;
            int actual = Implementations.ReverseNumbers(12345);
            Assert.AreEqual(expected, actual, "Actual and Expected do not match");
        }
        [Test]
        public void Test02_ReverseNumbersNegativ() //TC-08
        {
            int expected = 101;
            int actual = Implementations.ReverseNumbers(12345);
            Assert.AreNotEqual(expected, actual, "Actual and Expected do not match");
        }
        [Test]
        public void Test03_FctorialPositive() //TC-09
        {
            int expected = 120;
            int actual = Implementations.CalculateFactorial(5);
            Assert.AreEqual(expected, actual, "Actual and Expected do not match");
        }
        [Test]
        public void Test04_FctorialNegative() //TC-10
        {
            int expected = 25;
            int actual = Implementations.CalculateFactorial(5);
            Assert.AreNotEqual(expected, actual, "Actual and Expected do not match");
        }
        [Test]
        public void Test05_LongestwordPositive() //TC-11
        {
            string text = "hello im inigomontoia you kiil my father preper tol die";
            string expected = "inigomontoia";
            string actual = Implementations.LongestWord(text.Split(' '));
            Assert.AreEqual(expected, actual, "Actual and Expected do not match");
        }
        [Test]
        public void Test06_LongestwordNegative() //TC-12
        {
            string text = "hello im inigomontoia you kiil my father preper tol die";
            string expected = "im";
            string actual = Implementations.LongestWord(text.Split(' '));
            Assert.AreNotEqual(expected, actual, "Actual and Expected do not match");
        }
        [Test]
        public void Test07_SortNumbersPositive() //TC-13
        {
            int expected = 145669;
            int actual = SortNumbers.SN(615649);
            Assert.AreEqual(expected, actual, "Actual and Expected do not match");
        }
        [Test]
        public void Test08_SortNumbersNegativ() //TC-14
        {
            int expected = 101;
            int actual = Implementations.ReverseNumbers(145669);
            Assert.AreNotEqual(expected, actual, "Actual and Expected do not match");
        }
        //[Test]
        //public void Test09_ManuPositiv() //TC-05
      
        //[Test]
        //public void Test10_ManuNegativ() //TC-06

    }
}
