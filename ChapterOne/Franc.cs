using System;
using System.Collections.Generic;
using System.Text;

namespace ChapterOne
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public override Money times(int multiplier)
        {            
            return new Franc(amount * multiplier);
        }        
    }
}
