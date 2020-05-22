using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void T01_더하기()
        {
            int a = 5;
            int b = 5;

            int expected = 10;

            Assert.AreEqual(expected, a + b, "Add Failed");
        }
        

        [TestMethod]
        public void T02_빼기()
        {
            int a = 10;
            int b = 5;
            int expected = 5;

            Assert.AreEqual(expected, a - b, "Minus Failed");
        }

        [TestMethod]
        public void T03_1부터_10까지_더하기()
        {
            int sum = 0;
            for(int i=0; i<10; i++)
            {
                sum += i + 1;
            }

            int expected = 55;

            Assert.AreEqual(expected, sum, "Failed");
        }
    }
}
