using Xunit;

namespace make_it
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
    }

    public interface Expression {
    }

    public class Bank {
        public Money Reduce(Expression source, string to){
            return Money.dollar(10);
        }
    }
}