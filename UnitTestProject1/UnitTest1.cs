using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            int e = 10;
            int actyal = Da.Dada();
            Assert.AreEqual(e, actyal);
        }

        [TestMethod]
        public void TestMethod2()
        {
            
            int e = 12;
            int actyal = Da.Dada();
            Assert.AreEqual(e, actyal);
        }
    }
}
