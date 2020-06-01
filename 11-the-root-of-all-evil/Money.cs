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

        public static Dollar dollar(int amount, string currency){
            return new Dollar(amount, currency);
        }

        public static Franc franc(int amount, string currency){
            return new Franc(amount, currency);
        }

        public Money Times(int multiplier){
            return null;
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return this.Amount == money.Amount &&
                    this.Currency.Equals(money.Currency);
        }
    }
}