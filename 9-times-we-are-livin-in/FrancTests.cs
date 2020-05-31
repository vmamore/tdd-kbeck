using Xunit;

namespace times_we_are_livin_in
{
    public class FrancTests
    {
        [Fact]
        public void TestFrancMultiplication(){
            Franc five = new Franc(5, null);
            Assert.Equal(new Franc(10, null), five.Times(2));
            Assert.Equal(new Franc(15, null), five.Times(3));
        }
    }

    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }
        public override string Currency => _currency;
        public override Money Times(int multiplier)
        {
            return new Franc(this.Amount * multiplier, null);
        }
    }
}