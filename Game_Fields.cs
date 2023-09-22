using System;
namespace TTT
{
    public partial class Game
    {
        /*
X  | O |  X
___|___|___
  |   |
X  | X |  O
___|___|___
|   |
O  | O |  X
*/
        private bool StartNewGame = false;
        private int Selector { get; set; } = 0;
        private Cell[] Cells;
        public int MovesCount { get; set; } = 0;
        public char[] Player { get; set; } = { 'X', 'O' };
        public ConsoleColor BackGroundColor { get; set; } = ConsoleColor.Black;
        public ConsoleColor TextColor { get; set; } = ConsoleColor.White;
        public ConsoleColor FocusColor { get; set; } = ConsoleColor.Cyan;
        public ConsoleColor AlertColor { get; set; } = ConsoleColor.Red;
        public ConsoleColor HappyColor { get; set; } = ConsoleColor.Green;


    }
}
