using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class ExerciseCard:BasicCard
    {
        public string exrecise { get; set; }
        public int result { get; set; }
        public ExerciseCard(string exrecise,int result)
        {
            this.exrecise = exrecise;
            this.result = result;           
        }
        public override bool Pair(BasicCard otherCard)
        {
            if (otherCard is ExerciseCard)
            {
                if ((otherCard as ExerciseCard).exrecise.Equals(this.exrecise) && (otherCard as ExerciseCard).result.Equals(this.result))
                    return true;
            }
            return false;
        }
        public override void DrawCard()
        {
            if (base.isDiscover)
            {
                Console.WriteLine(" -------");
                Console.WriteLine("| " + this.exrecise + "=" + this.result + " |");
                Console.WriteLine(" -------");
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
