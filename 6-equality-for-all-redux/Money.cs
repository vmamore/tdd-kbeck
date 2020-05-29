namespace equality_for_all_redux
{
    public class Money
    {
        public int Amount { get; protected set; }

        public override bool Equals(object obj)
        {
            Money dollar = (Money)obj;
            return this.Amount == dollar.Amount;
        }
    }
}