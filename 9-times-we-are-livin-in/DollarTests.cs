using System;
using Xunit;

namespace times_we_are_livin_in
{
    public class DollarTests
    {
        [Fact]
        public void TestMoreThanOneMultiplication()
        {
            Dollar five = new Dollar(5, null);
            Assert.Equal(new Dollar(10, null), five.Times(2));;
            Assert.Equal(new Dollar(15, null), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5, null).Equals(new Dollar(5, null)));
            Assert.False(new Dollar(5, null).Equals(new Dollar(6, null)));
        }

        [Fact]
        public void TestMultiplication()
        {
            Money five = Money.dollar(5);
            Assert.Equal(new Dollar(10, null), five.Times(2));
            Assert.Equal(new Dollar(15, null), five.Times(3));
        }

        [Fact]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.dollar(1).Currency);
            Assert.Equal("CHF", Money.franc(1).Currency);
        }
    }

    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }
        public override string Currency => _currency;

        public override Money Times(int multiplier)
        {
            return new Dollar(this.Amount * multiplier, null);
        }
    }
}
