using console_chess.Board;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Utility
{
    public static class AlphabetIndex
    {
        public static int GetIndex(Position position)
        {
            return (int)position.ToString().ToCharArray()[0] % 32;
        }

        public static int GetIndexDiff(Move move)
        {
            int newPosAlphaIndex = (int)move.NewPosition.ToString().ToCharArray()[0] % 32;
            int oldPosAlphaIndex = (int)move.OldPosition.ToString().ToCharArray()[0] % 32;
            return (newPosAlphaIndex - oldPosAlphaIndex);
        }

        public static int GetAbsoluteIndexDiff(Move move)
        {
            int newPosAlphaIndex = (int)move.NewPosition.ToString().ToCharArray()[0] % 32;
            int oldPosAlphaIndex = (int)move.OldPosition.ToString().ToCharArray()[0] % 32;
            return Math.Abs(newPosAlphaIndex - oldPosAlphaIndex);
        }

        public static bool PositionNumbersMatch(Position firstPosition, Position secondPosition)
        {
            int firstNum = (int)firstPosition.ToString().ToCharArray()[1];
            int secondNum = (int)secondPosition.ToString().ToCharArray()[1];

            return (firstNum == secondNum);
        }
    }
}
