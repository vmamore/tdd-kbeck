using System;
using Xunit;

namespace mixed_currencies
{
    public class DollarTests
    {
        [Fact]
        public void TestMoreThanOneMultiplication()
        {
            Money five = new Money(5, "USD");
            Assert.Equal(new Money(10, "USD"), five.Times(2));;
            Assert.Equal(new Money(15, "USD"), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.False(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.False(Money.franc(5).Equals(Money.dollar(5)));
        }

        [Fact]
        public void TestDifferentClassEquality()
        {
            Assert.True(new Money(10, "CHF").Equals(new Money(10, "CHF")));
        }
    }
}
