using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod1()
        {
            var a = 0;
            try
            {
                var x = 1 / a;
            }
            catch (DivideByZeroException ex)
            {
                StringAssert.Contains(ex.Message, "divide");
                throw;
            }
        }
    }
}
