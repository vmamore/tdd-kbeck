namespace apples_and_oranges
{
    public class Money
    {
        public int Amount { get; protected set; }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return this.Amount == money.Amount &&
                    this.GetType().Name.Equals(money.GetType().Name);
        }
    }
}