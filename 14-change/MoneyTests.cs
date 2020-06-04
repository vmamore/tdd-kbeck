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
    }

    public interface Expression {
        Money Reduce(string to);
    }

    public class Bank {
        public Money Reduce(Expression source, string to){
            if(source is Money) return source.Reduce(to);
            Sum sum = source as Sum;
            return sum.Reduce(to);
        }
    }

    public class Sum : Expression{
        public Money Augend {get;set;}
        public Money Addend {get;set;}

        public Sum(Money augend, Money addend){
            this.Augend = augend;
            this.Addend = addend;
        }

        public Money Reduce(string to){
            int amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }
    }
}