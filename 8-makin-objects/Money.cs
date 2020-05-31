namespace makin_objects
{
    public abstract class Money
    {
        public int Amount { get; protected set; }

        public static Dollar dollar(int amount){
            return new Dollar(amount);
        }

        public static Franc franc(int amount){
            return new Franc(amount);
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