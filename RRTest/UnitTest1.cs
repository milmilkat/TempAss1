using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TempAss1;

namespace RRTest
{
    [TestClass]
    public class UnitTest1
    {
        Logic LogicClass = new Logic();

        [TestMethod]
        public void TestMethod1()
        {
            int testable = LogicClass.ShootAway();

            Assert.AreEqual(1, testable);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int testable = LogicClass.ShootAway();

            Assert.AreNotEqual(2, testable);
        }
    }
}
