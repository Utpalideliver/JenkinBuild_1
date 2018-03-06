using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinBuildApp_1;

namespace JenkinTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello Jenkins", Program.createmessage());
        }
    }
}
