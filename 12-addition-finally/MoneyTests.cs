using Xunit;

namespace addition_finally
{
    public class MoneyTests
    {
        [Fact]
        public void TestSimpleAddition(){
            Money sum = Money.dollar(5).Plus(Money.dollar(5));
            Assert.Equal(Money.dollar(10), sum);
        }
    }
}