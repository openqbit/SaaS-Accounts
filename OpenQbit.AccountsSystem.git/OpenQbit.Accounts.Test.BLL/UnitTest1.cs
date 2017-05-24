using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenQbit.Accounts.Test.BLL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 20;
            //int actual = 8;

            int actual = calArea(2, 10);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int expected = 20;
            int actual = 8;

           

            Assert.AreEqual(expected, actual);

        }


        public int calArea(int w, int h)
        {

            return w * h;

        }

    }
}
