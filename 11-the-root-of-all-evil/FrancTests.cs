using Xunit;

namespace the_root_of_all_evil
{
    public class FrancTests
    {
        [Fact]
        public void TestFrancMultiplication(){
            Money five = new Money(5, "CHF");
            Assert.Equal(new Money(10, "CHF"), five.Times(2));
            Assert.Equal(new Money(15, "CHF"), five.Times(3));
        }
    }
}