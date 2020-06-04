using Xunit;

namespace change
{
    public class MoneyTests
    {
        [Fact]
        public void TestSimpleAddition(){
            var five = Money.dollar(5);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.Equal(Money.dollar(10), reduced);
        }

        [Fact]
        public void TestPlusReturnsSum(){
            var five = Money.dollar(5);
            Expression result = five.Plus(five);
            Sum sum = (Sum)result;
            Assert.Equal(five, sum.Augend);
            Assert.Equal(five, sum.Addend);
        }

        [Fact]
        public void TestReduceSum(){
            Expression sum = new Sum(Money.dollar(3), Money.dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.dollar(7), result);
        }

        [Fact]
        public void TestReduceMoney(){
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.dollar(1), "USD");
            Assert.Equal(Money.dollar(1), result);
        }

        [Fact]
        public void TestReduceMoneyDifferentCurrency(){
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.franc(2), "USD");
            Assert.Equal(Money.dollar(1), result);
        }

        [Fact]
        public void TestIdentityRate(){
            Assert.Equal(1, new Bank().Rate("USD", "USD"));
        }
    }
}