using System;
using Xunit;

namespace degenerate_objects
{
    public class DollarTests
    {
        [Fact]
        public void TestMultiplication(){
            Dollar five = new Dollar(5);
            Dollar result = five.times(2);
            Assert.Equal(10, result.Amount);
        }

        [Fact]
        public void TestMoreThanOneMultiplication(){
            Dollar five = new Dollar(5);
            Dollar product = five.times(2);
            Assert.Equal(10, product.Amount);
            product = five.times(3);
            Assert.Equal(15, product.Amount);
        }
    }

    public class Dollar {
        public int Amount { get; private set; }
        public Dollar(int amount){
            this.Amount = amount;
        }

        public Dollar times(int multiplier){
            return new Dollar(this.Amount * multiplier);
        }
    }
}
