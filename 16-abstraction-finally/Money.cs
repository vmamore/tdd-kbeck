namespace abstraction_finally
{
    public class Money : Expression
    {
        public int Amount { get; protected set; }
        public string Currency { get {return _currency;} }
        protected string _currency;

        public Money(int amount, string currency){
            Amount = amount;
            this._currency = currency;
        }

        public static Money dollar(int amount){
            return new Money(amount, "USD");
        }

        public Expression Plus(Expression addend){
            return new Sum(this, addend);
        }

        public static Money franc(int amount){
            return new Money(amount, "CHF");
        }

        public Expression Times(int multiplier){
            return new Money(Amount * multiplier, Currency);
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return this.Amount == money.Amount &&
                    this.Currency.Equals(money.Currency);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            return new Money(Amount/ rate, to);
        }
    }
}