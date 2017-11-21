using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitDemo
{
    public class FirstTests
    {
        [Fact]
        public void FirstTest()
        {
            var a = 0;
            var ex = Assert.Throws<DivideByZeroException>(() => 1 / a);
            Assert.Contains("divide", ex.Message);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void TheoryDemoAdd(int a, int b, int expected)
        {
            Assert.Equal(expected, a + b);
        }
    }
}
