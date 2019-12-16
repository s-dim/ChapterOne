using System;
using System.Collections.Generic;
using System.Text;

namespace ChapterOne
{
    abstract public class Money
    {        
        protected int amount;

        abstract public Money times(int multiplier);

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;

            return amount == money.amount && (this.GetType().Equals(money.GetType()));
        }

        public static Money dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money franc(int amount)
        {
            return new Franc(amount);
        }
    }
}
