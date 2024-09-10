using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class SignCard:BasicCard
    {
        public char sign { get; set; }
        public string color { get; set; }
        public SignCard(char sign, string color)
        {
            this.sign = sign;
            this.color = color; 
        }
        public override bool Pair(BasicCard otherCard)
        {
            if(otherCard is SignCard)
            { 
                if((otherCard as SignCard).sign==this.sign && (otherCard as SignCard).color.Equals(this.color))
                    return true;
            }
            return false;
        }
        public override void DrawCard()
        {
            if (base.isDiscover)
            {
                Console.WriteLine(" ---");
                Console.WriteLine("| " + this.sign + " |");
                Console.WriteLine(" ---");
              
            }
            else
            {
                Console.WriteLine(" ---");
                Console.WriteLine("|   |");
                Console.WriteLine(" ---");
            }
        }

    }
}
