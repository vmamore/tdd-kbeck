namespace change
{
    public class Sum : Expression{
        public Money Augend {get;set;}
        public Money Addend {get;set;}

        public Sum(Money augend, Money addend){
            this.Augend = augend;
            this.Addend = addend;
        }

        public Money Reduce(Bank bank, string to){
            int amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }
    }
}