using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    abstract class BasicPlayer
    {
        public int points { get; set; }
        public BasicCard[] cardGuess { get; set; }
        public string name { get; set; }
        public BasicPlayer(int size)
        {
            this.points = 0;
            cardGuess = new BasicCard[size];
            Rename();
        }
        public virtual void Rename() 
        {

        }
        public abstract int ChooseCard();      
    }
}
