using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WebApp_ForDevOps.UnitTesting
{
    public class MyMathServiceTest
    {
        [Theory]
        [InlineData(8, 2, 10)]
        [InlineData(11, 3, 14)]
        public void AddTest(double x, double y, double expectedValue)
        {
            var calculator = new MyMathService();
            var result = calculator.Add(x,y);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(8, 2, 64)]
        [InlineData(11, 3, 1331)]
        public void RaiseTest(double x, int y, double expectedValue)
        {
            var calculator = new MyMathService();
            var result = calculator.Raise(x, y);
            Assert.Equal(expectedValue, result);
        }
        [Theory]
        [InlineData(86,43)]
        [InlineData(856, 428)]
        public void HalfTest(double x, double expectedValue)
        {
            var calculator = new MyMathService();
            var result = calculator.Half(x);
            Assert.Equal(expectedValue, result);
        }
    }
}
