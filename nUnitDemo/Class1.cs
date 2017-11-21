using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitDemo
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestMethod2()
        {
            var a = 0;
            int x;
            var ex = Assert.Throws<DivideByZeroException>(() => x = 1 / a);
            StringAssert.Contains("divide", ex.Message);
        }
    }
}
