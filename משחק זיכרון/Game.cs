using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class Game
    {
        public BasicPlayer[] players { get; set; }
        public BasicCard[] arrCard { get; set; }
        public int index { get; set; }
        public Board b { get; set; }
        public void RestartGame()
        {
            Console.WriteLine("enter cnt of players");
            int cnt = int.Parse(Console.ReadLine());
            this.players = new BasicPlayer[cnt];
            arrCard = new BasicCard[]
            {
                new SignCard('@', "orange"),
                new SignCard('@', "orange"),
                new LetterCard('Y'),
                new LetterCard('Y'),
                new ExerciseCard("6+7", 13),                
                new ExerciseCard("6+7", 13),
                new SignCard('!', "red"),
                new SignCard('!', "red"),
                new LetterCard('A'),
                new LetterCard('A')
            };
            players[0] = new UserPlayer(arrCard.Length);
            b = new Board(arrCard.Length);
            //אתחול מערך השחקנים
            for (int i = 1; i < cnt ; i++)
            {
                Console.WriteLine("enter 1 for computer and 2 for user");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        this.players[i] = new ComputerPlayer(arrCard.Length);
                        break;
                    case 2:
                        this.players[i] = new UserPlayer(arrCard.Length);
                        break;
                }
            }
            b.RestartBoard(arrCard);

            StartPlay();
        }
        public void FoundPair(int ind1, int ind2)
        {
            for (int i = 0; i < players[index].cardGuess.Length; i++)
            {
                if (players[index].cardGuess[i] == null)
                {
                    players[index].cardGuess[i] = b.cardBoard[ind1];
                    players[index].cardGuess[i + 1] = b.cardBoard[ind2];
                    break;
                }
            }
            b.cardBoard[ind1] = null;
            b.cardBoard[ind2] = null;
            players[index].points++;
        }
        public void Winner()
        {
            int max = 0, maxInd = 0;
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].points > max)
                {
                    max = players[i].points;
                    maxInd = i;
                }
            }
            Console.WriteLine("the winner is: " + players[maxInd].name);
        }
        public void StartPlay()
        {
            int x=0, y=0;
            b.DrawBoard();
            while ((b.IsExist()))
            {
                for (int i = 0; i < players.Length; i++)
                {
                    this.index = i;

                    do
                    {
                        x = players[i].ChooseCard();
                    } while (!(b.IsLegal(x)));
                    b.cardBoard[x].isDiscover = true;
                    b.DrawBoard();
                    do
                    {
                        y = players[i].ChooseCard();
                    } while (!(b.IsLegal(y)));
                    b.cardBoard[y].isDiscover = true;
                    b.DrawBoard();
                    b.cardBoard[x].isDiscover = false;
                    b.cardBoard[y].isDiscover = false;
                    if (b.cardBoard[x].Pair(b.cardBoard[y]))
                    {
                        FoundPair(x, y);
                    }
                }
            }
            Winner();
        }
    }
}
