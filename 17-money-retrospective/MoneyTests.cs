using Xunit;

namespace money_retrospective
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

        [Fact]
        public void TestMixedAddition(){
            Expression fiveBucks = Money.dollar(5);
            Expression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.Equal(Money.dollar(10), result);
        }

        [Fact]
        public void TestSumPlusMoney(){
            Expression fiveBucks = Money.dollar(5);
            Expression tenFrancs =  Money.franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).Plus(fiveBucks);
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.dollar(15), result);
        }

        [Fact]
        public void TestSumTimes(){
            Expression fiveBucks = Money.dollar(5);
            Expression tenFrancs =  Money.franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).Times(2);
            Money result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.dollar(20), result);
        }

        [Fact]
        public void TestPlusSameCurrencyReturnsMoney(){
            Expression sum = Money.dollar(1).Plus(Money.dollar(1));
            Assert.IsType<Money>(sum);
        }
    }
}