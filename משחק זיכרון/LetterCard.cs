using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class LetterCard:BasicCard
    {
        public char letter { get; set; }
        public LetterCard(char letter)
        {
            this.letter = letter;
        }
        public override bool Pair(BasicCard otherCard)
        {
            if (otherCard is LetterCard)
            {
                if ((otherCard as LetterCard).letter == this.letter)
                    return true;
            }
            return false;
        }
        public override void DrawCard()
        {
            if (base.isDiscover)
            {
                Console.WriteLine(" ---");
                Console.WriteLine("| " + this.letter + " |");
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
