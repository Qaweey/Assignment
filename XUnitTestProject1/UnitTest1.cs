using System;
using WebApplication2.utilities;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {


        [Theory]
        [InlineData(10000, 5, 1, 10500)]
        [InlineData(1, 5, 1, 1)]
        [InlineData(-20000, 10, 0.5, 0)]
        [InlineData(2000, 5, 1, 2100)]
        public void Test2(decimal principal, decimal rate, decimal time, decimal sum)
        {
            var save = new Savings();
            var mySum = save.InterestCalculator(principal, rate, time);
            Assert.Equal(sum,mySum);
        }
    }
}
