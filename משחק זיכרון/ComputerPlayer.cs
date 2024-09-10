using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class ComputerPlayer:BasicPlayer
    {
        public ComputerPlayer(int size) : base(size) { }

        public override void Rename()
        {
            base.name = "computer";
        }
        public override int ChooseCard()
        {
           Random random = new Random();
           return random.Next(base.cardGuess.Length);           
        }
    }
}
