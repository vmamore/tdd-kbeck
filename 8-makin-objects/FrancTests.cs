using Xunit;

namespace makin_objects
{
    public class FrancTests
    {
        [Fact]
        public void TestFrancMultiplication(){
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10), five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
        }
    }

    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.Amount = amount;
        }
        public override Money Times(int multiplier)
        {
            return new Franc(this.Amount * multiplier);
        }
    }
}