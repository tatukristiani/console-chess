using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess
{
    public class ChessBoard
    {
        private int[,] _board = { 
            {-4, -2, -3, -5, -6, -3, -2, -4 }, 
            {-1, -1, -1, -1, -1, -1, -1, -1},
            {0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0 },
            {1, 1, 1, 1, 1, 1, 1, 1},
            {4, 2, 3, 5, 6, 3, 2, 4 }
        };

        public ChessBoard()
        {

        }

        public void PrintBoard()
        {
            int count = 0;
            foreach(var position in _board)
            {
                if (count == 0) Console.Write("|");

                if (position < 0) Console.Write(" " + position + " ");
                else Console.Write("  " + position + " ");
                Console.Write("|");
              
                if (count != 7)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("+----+----+----+----+----+----+----+----+");
                    count = 0;
                }
            } 
        }
    }
}
