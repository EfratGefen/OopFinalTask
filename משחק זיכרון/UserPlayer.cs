using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class UserPlayer:BasicPlayer
    {
        public UserPlayer(int size):base(size) { }
       
        public override void Rename()
        {
            Console.WriteLine("enter your name");
            base.name=Console.ReadLine();
        }
        public override int ChooseCard()
        {
            Console.WriteLine(base.name+": enter num of card to inverted");
            return int.Parse(Console.ReadLine());
        }
    }
}
