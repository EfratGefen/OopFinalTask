using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    abstract class BasicCard
    {
        public bool isDiscover { get; set; }
        public bool numCard { get; set; }
        public abstract bool Pair(BasicCard otherCard);
        public abstract void DrawCard();    
    }
}
