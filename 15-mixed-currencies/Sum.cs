namespace mixed_currencies
{
    public class Sum : Expression{
        public Expression Augend {get;set;}
        public Expression Addend {get;set;}

        public Sum(Expression augend, Expression addend){
            this.Augend = augend;
            this.Addend = addend;
        }

        public Money Reduce(Bank bank, string to){
            int amount = Augend.Reduce(bank, to).Amount + 
            Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        public Expression Plus(Expression addend)
        {
            return null;
        }
    }
}