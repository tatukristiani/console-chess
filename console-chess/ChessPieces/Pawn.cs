using console_chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.ChessPieces
{
    public class Pawn : AChessPiece
    {
        public Pawn(int code) : base(code)
        {
        }

        public override bool IsValidMove(Position currentPosition, Position newPosition)
        {
            int positionDifference = newPosition - currentPosition;
            if (base.Color == Color.White)
            {
                // Is it the first move for the Pawn?
                if (currentPosition.ToString().Contains("2"))
                {
                    return positionDifference == -8 || positionDifference == -16;
                }
                else
                {
                    return positionDifference == -8;
                }

            }
            else
            {
                if(currentPosition.ToString().Contains("7"))
                { 
                    return positionDifference == 8 || positionDifference == 16;
                }
                else
                {
                    return positionDifference == 8;
                }
            }
               
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
