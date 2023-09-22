using System;
namespace TTT
{
    public class Rules
    {
        public const int MaxMove = 9;
        public bool PlayerWon;
        public bool FillWithNumber { get; set; } = false;
        public int CurrentPlayer { get; set; } = 0;
        public bool IsValidMove(int move, Cell[] cells)
        {
            if (cells[move].IsEmpty == true)
            {
                return true;
            }

            return false;
        }


    }
}
