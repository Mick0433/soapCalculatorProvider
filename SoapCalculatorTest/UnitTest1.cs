using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using soapCalculatorProvider;
using SoapCalculatorTest.ServiceReference1;

namespace SoapCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Service1 s = new Service1();
            var res = s.Subtract(5, 2);
            Assert.AreEqual(3, res);
        }
    }
    
}
