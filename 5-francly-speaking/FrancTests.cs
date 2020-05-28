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
}