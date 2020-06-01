using Xunit;

namespace the_root_of_all_evil
{
    public class FrancTests
    {
        [Fact]
        public void TestFrancMultiplication(){
            Franc five = new Franc(5, "CHF");
            Assert.Equal(new Franc(10, "CHF"), five.Times(2));
            Assert.Equal(new Franc(15, "CHF"), five.Times(3));
        }
    }

    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }
        public new Money Times(int multiplier)
        {
            return new Money(this.Amount * multiplier, Currency);
        }
    }
}