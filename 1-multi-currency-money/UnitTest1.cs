using System;
using Xunit;

namespace multi_currency_money
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultiplication(){
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.Equal(10, five.amount);
        }
    }
}
