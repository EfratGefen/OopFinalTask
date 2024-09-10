using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משחק_זיכרון
{
    internal class Board
    {
        public int sizeBoard { get; set; }
        public BasicCard[] cardBoard { get; set; }
        public Board(int size)
        {
            this.sizeBoard = size;
            cardBoard = new BasicCard[size];
        }
        public void RestartBoard(BasicCard[] c)
        {
            Random r = new Random();
            int x, y;
            for (int i = 0; i < cardBoard.Length; i++)
            {
                if (cardBoard[i] == null)
                {
                    do
                    {
                        x = r.Next(c.Length);
                    }
                    while (c[x] == null);
                    cardBoard[i] = c[x];
                    //do
                    //{
                    //    y = r.Next(cardBoard.Length);
                    //}
                    //while (cardBoard[y]!=null);
                    //cardBoard[y] = c[x];
                    c[x] = null;
                }
            }
           
        }
        public void DrawBoard()
        {
            for (int i = 0; i < cardBoard.Length; i++)
            {
                if (cardBoard[i] != null)
                {                 
                    cardBoard[i].DrawCard();
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("----------------------");
        }
        public bool IsLegal(int x)
        {
            if (cardBoard[x] != null && x < cardBoard.Length && x >= 0)
                return true;
            return false;
        }
        public bool IsExist()
        {
            for (int i = 0; i < cardBoard.Length; i++)
            {
                if (cardBoard[i] != null)
                    return true;
            }
            return false;
        }
    }
}
