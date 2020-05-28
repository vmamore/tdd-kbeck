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
            Assert.Equal(10, five.Amount);
        }
    }

    public class Dollar {
        public int Amount { get; private set; }
        public Dollar(int amount){
            this.Amount = amount;
        }

        public void times(int multiplier){
            this.Amount *= multiplier;
        }
    }
}
