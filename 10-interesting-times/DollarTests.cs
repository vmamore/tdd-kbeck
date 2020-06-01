using System;
using Xunit;

namespace interesting_times
{
    public class DollarTests
    {
        [Fact]
        public void TestMoreThanOneMultiplication()
        {
            Dollar five = new Dollar(5, "USD");
            Assert.Equal(new Dollar(10, "USD"), five.Times(2));;
            Assert.Equal(new Dollar(15, "USD"), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5, "USD").Equals(new Dollar(5, "USD")));
            Assert.False(new Dollar(5, "USD").Equals(new Dollar(6, "USD")));
        }

        // [Fact]
        // public void TestMultiplication()
        // {
        //     Money five = Money.dollar(5);
        //     Assert.Equal(new Dollar(10, null), five.Times(2));
        //     Assert.Equal(new Dollar(15, null), five.Times(3));
        // }

        // [Fact]
        // public void TestCurrency()
        // {
        //     Assert.Equal("USD", Money.dollar(1).Currency);
        //     Assert.Equal("CHF", Money.franc(1).Currency);
        // }

        [Fact]
        public void TestDifferentClassEquality()
        {
            Assert.True(new Money(10, "CHF").Equals(new Franc(10, "CHF")));
        }
    }

    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public new Money Times(int multiplier)
        {
            return new Money(this.Amount * multiplier, Currency);
        }
    }
}
