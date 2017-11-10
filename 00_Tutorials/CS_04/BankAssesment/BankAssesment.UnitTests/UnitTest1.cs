using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Now that we added a new project to solution we will build both projects


namespace BankAssesment.UnitTests
{
    // A class that has test methods
    [TestClass]
    public class UnitTest1
    {
        // A method that should be executed and checked to see if they passed or failed
        [TestMethod]
        public void TestMethod1()
        {
            // Test failed
            Assert.AreEqual(4, 4);
        }
    }
}
