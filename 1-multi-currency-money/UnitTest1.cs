using System;
using Xunit;

namespace multi_currency_money
{
    public class DollarTests
    {
        [Fact]
        public void TestMultiplication(){
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.Equal(10, five.amount);
        }
    }

    public class Dollar {
        public int amount;
        public Dollar(int amount){

        }

        public void times(int multiplier){

        }
    }
}
