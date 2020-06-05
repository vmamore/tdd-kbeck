using System.Collections.Generic;

namespace mixed_currencies
{
    public class Bank {

        private Dictionary<Pair, int> rates = new Dictionary<Pair, int>();
        public Money Reduce(Expression source, string to){
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate){
            rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to) {
            if(from.Equals(to)) return 1;
            int rate = rates[new Pair(from, to)];
            return rate;
        }
    }
}