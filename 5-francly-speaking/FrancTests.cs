using Xunit;

namespace francly_speaking
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

    public class Franc
    {
        private int Amount;
        public Franc(int amount)
        {
            this.Amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(this.Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc dollar = (Franc)obj;
            return this.Amount == dollar.Amount;
        }
    }
}