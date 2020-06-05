namespace mixed_currencies
{
    public interface Expression {
        Money Reduce(Bank bank, string to);
    }
}