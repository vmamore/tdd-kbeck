namespace the_root_of_all_evil
{
    public class Money
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

        public static Money franc(int amount){
            return new Money(amount, "CHF");
        }

        public Money Times(int multiplier){
            return new Money(Amount * multiplier, Currency);
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return this.Amount == money.Amount &&
                    this.Currency.Equals(money.Currency);
        }
    }
}