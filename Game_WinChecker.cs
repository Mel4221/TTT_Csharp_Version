using System;
namespace TTT
{
    public partial class Game
    {


        private bool WinChecker()
        {
            /*
            Start of Lateral win check 
            X X X or O O O               
            */
            if (this.Cells[0].Value == this.Player[0]
            && this.Cells[1].Value == this.Player[0]
            && this.Cells[2].Value == this.Player[0]
                )
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[0].Value == this.Player[1]
                && this.Cells[1].Value == this.Player[1]
                && this.Cells[2].Value == this.Player[1]
                    )
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[3].Value == this.Player[0]
                && this.Cells[4].Value == this.Player[0]
                && this.Cells[5].Value == this.Player[0]
                    )
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[3].Value == this.Player[1]
            && this.Cells[4].Value == this.Player[1]
            && this.Cells[5].Value == this.Player[1]
                )
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[6].Value == this.Player[0]
               && this.Cells[7].Value == this.Player[0]
               && this.Cells[8].Value == this.Player[0]
           )
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[6].Value == this.Player[1]
                && this.Cells[7].Value == this.Player[1]
                && this.Cells[8].Value == this.Player[1]
                )
            {
                this.PlayerWon = true;
                return true;
            }
            /*
                End of Lateral win check 
                X X X or O O O               
            */
            /*
                Start of Vertial win check
                X       O
                X       O
                X  or   O            
            */
            if (this.Cells[0].Value == this.Player[0]
                && this.Cells[3].Value == this.Player[0]
                && this.Cells[6].Value == this.Player[0]
                )
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[0].Value == this.Player[1]
    && this.Cells[3].Value == this.Player[1]
    && this.Cells[6].Value == this.Player[1]
    )
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[1].Value == this.Player[0]
    && this.Cells[4].Value == this.Player[0]
    && this.Cells[7].Value == this.Player[0]
    )
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[1].Value == this.Player[1]
&& this.Cells[4].Value == this.Player[1]
&& this.Cells[7].Value == this.Player[1]
)
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[2].Value == this.Player[0]
&& this.Cells[5].Value == this.Player[0]
&& this.Cells[8].Value == this.Player[0]
)
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[2].Value == this.Player[1]
&& this.Cells[5].Value == this.Player[1]
&& this.Cells[8].Value == this.Player[1]
)
            {
                this.PlayerWon = true;
                return true;
            }
            /*
            End of Vertial win check
            X       O
            X       O
            X  or   O            
        */
            /*
                Start of lateral win check 
                X                   O
                    X           O
                        X or O                
            */
            if (this.Cells[0].Value == this.Player[0]
&& this.Cells[4].Value == this.Player[0]
&& this.Cells[8].Value == this.Player[0]
)
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[0].Value == this.Player[1]
&& this.Cells[4].Value == this.Player[1]
&& this.Cells[8].Value == this.Player[1]
)
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[2].Value == this.Player[0]
&& this.Cells[4].Value == this.Player[0]
&& this.Cells[6].Value == this.Player[0]
)
            {
                this.PlayerWon = true;
                return true;
            }
            if (this.Cells[2].Value == this.Player[1]
&& this.Cells[4].Value == this.Player[1]
&& this.Cells[6].Value == this.Player[1]
)
            {
                this.PlayerWon = true;
                return true;
            }
            /*
          Start of lateral win check 
          X                   O
              X           O
                  X or O                
            */

            //Returns False if any of the win rules are met
            return false;
        }
    }
}
/*
    0 1 2 
    3 4 5
    6 7 8
*/