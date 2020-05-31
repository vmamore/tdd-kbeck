namespace times_we_are_livin_in
{
    public abstract class Money
    {
        public int Amount { get; protected set; }
        public abstract string Currency { get; }
        protected string _currency;

        public Money(int amount, string currency){
            Amount = amount;
            this._currency = currency;
        }

        public static Dollar dollar(int amount){
            return new Dollar(amount, "USD");
        }

        public static Franc franc(int amount){
            return new Franc(amount, "CHF");
        }

        public abstract Money Times(int multiplier);

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return this.Amount == money.Amount &&
                    this.GetType().Name.Equals(money.GetType().Name);
        }
    }
}