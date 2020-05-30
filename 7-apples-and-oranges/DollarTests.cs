using System;
using Xunit;

namespace apples_and_oranges
{
    public class DollarTests
    {
        [Fact]
        public void TestMoreThanOneMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.Equal(new Dollar(10), five.Times(2));;
            Assert.Equal(new Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }

    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(this.Amount * multiplier);
        }
    }
}
