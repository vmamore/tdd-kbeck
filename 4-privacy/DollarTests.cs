using System;
using Xunit;

namespace privacy
{
    public class DollarTests
    {
        [Fact]
        public void TestMoreThanOneMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.Equal(new Dollar(10), five.times(2));;
            Assert.Equal(new Dollar(15), five.times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }

    public class Dollar
    {
        private int Amount;
        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(this.Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return this.Amount == dollar.Amount;
        }
    }
}
