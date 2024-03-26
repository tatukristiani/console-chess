using console_chess.Board;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Utility
{
    /// <summary>
    /// Utility class that helps to get the differences of chess piece positions on the chess board.
    /// </summary>
    public static class AlphabetIndex
    {
        /// <summary>
        /// Gets the alphabetical index number eq. A = 1, B = 2 etc.
        /// </summary>
        /// <param name="position">Position object which index is wanted</param>
        /// <returns>int value, alphabetical index of the given position</returns>
        public static int GetIndex(Position position)
        {
            return (int)position.ToString()[0] % 32;
        }

        /// <summary>
        /// Method to get the alphabetical index difference of the Move object.
        /// Alphabetical index of move.NewPosition - move.OldPosition.
        /// 
        /// eq. OldPosition = Position.B1, NewPosition = Position.A1
        /// -> 1 - 2 = -1
        /// </summary>
        /// <param name="move">Move object</param>
        /// <returns>int value, alphabetical index difference of new and old position</returns>
        public static int GetIndexDiff(Move move)
        {
            int newPosAlphaIndex = (int)move.NewPosition.ToString()[0] % 32;
            int oldPosAlphaIndex = (int)move.OldPosition.ToString()[0] % 32;
            return (newPosAlphaIndex - oldPosAlphaIndex);
        }

        /// <summary>
        /// Method to get the absolute alphabetical index difference on Move object.
        /// Alphabetical index of move.NewPosition - move.OldPosition (absolute)
        /// 
        /// eq. OldPosition = Position.B1, NewPosition = Position.A1
        /// -> 1 - 2 = Math.Abs(-1) which results in 1
        /// </summary>
        /// <param name="move">Move object</param>
        /// <returns>int value, absolute alphabetical index difference of new and old position</returns>
        public static int GetAbsoluteIndexDiff(Move move)
        {
            int newPosAlphaIndex = (int)move.NewPosition.ToString()[0] % 32;
            int oldPosAlphaIndex = (int)move.OldPosition.ToString()[0] % 32;
            return Math.Abs(newPosAlphaIndex - oldPosAlphaIndex);
        }

        /// <summary>
        /// Method for checking if the the number of the two given Positions match
        /// eq. firstPosition = Position.A1, secondPosition = Position.C1 would return true
        /// </summary>
        /// <param name="firstPosition">First Position enum</param>
        /// <param name="secondPosition">Second Position enum</param>
        /// <returns>true when the numbers match on the Position values, false otherwise</returns>
        public static bool PositionNumbersMatch(Position firstPosition, Position secondPosition)
        {
            int firstNum = (int)firstPosition.ToString()[1];
            int secondNum = (int)secondPosition.ToString()[1];

            return (firstNum == secondNum);
        }
    }
}
