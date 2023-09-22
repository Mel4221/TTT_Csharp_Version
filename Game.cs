using System;
namespace TTT
{
  
   
    public partial class Game:Rules
    {

        private void ResetGame()
        {
            for(int item = 0; item < this.Cells.Length; item++)
            {
                this.Cells[item].Reset(); 
            }
        }



        public void Play()
        {
         

            if (IsValidMove(this.Selector, this.Cells))
            {
                this.Cells[this.Selector].Value = this.Player[this.CurrentPlayer];
                this.Cells[this.Selector].IsEmpty = false;
                this.MovesCount++;
                if (this.WinChecker())
                {
                    Console.ForegroundColor = this.HappyColor;
                    Console.BackgroundColor = this.BackGroundColor;
                    string player = this.CurrentPlayer == 0 ? "Player1" : "Player2";
                    Console.Write($"Player: {player} [{this.Player[this.CurrentPlayer]}] Congratulations You Won!!!");
                    Console.ReadKey();
                    this.ResetGame();
                    this.Selector = 0; 
                    return;
                }
                this.CurrentPlayer = this.CurrentPlayer == 0 ? 1 : 0; 
            }
           
            if (this.MovesCount == MaxMove && this.PlayerWon == false)
            {
                Console.WriteLine("Is a Tie"); 
                Console.ReadKey();
                this.ResetGame();
                this.Selector = 0; 
                return; 
            }

        }
        private void GameLoop()
        {
            while(this.StartNewGame == false)
            {
                ConsoleKeyInfo info = Console.ReadKey();

                switch (info.Key)
                {
                    /*
                     * Grid Rule:                    
                     * Foward will always be incremented by 1 but
                     * down and up will be decrementing by the 
                     * amount of items of the row
                    1 2 3 4 5 6 7 8 9

                    1 2 3
                    4 5 6
                    7 8 9
                    
                    sm = n 
                    */
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if(this.Selector > 0)
                        {
                            this.Selector = this.Selector - 3;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if(this.Selector  < 9)
                        {
                            this.Selector = this.Selector + 3;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if(this.Selector > 0)
                        {
                            this.Selector--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if(this.Selector < 9)
                        {
                            this.Selector++;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0); 
                        return;
                    case ConsoleKey.Enter:
                        this.Play(); 
                        break;
                    case ConsoleKey.H:
                        if(info.Modifiers == ConsoleModifiers.Control)
                        {
                            this.PrintHistory();
                        }
                        break;
                    case ConsoleKey.C:
                        if (info.Modifiers == ConsoleModifiers.Control)
                        {
                            this.ManageConfiguration();
                        }
                        break;
                }
                // Print(); 
                this.PrintMap();
              
            }
        }

        //string str = $"X: {Selector} Y: {Selector} F[{Selector + Selector }] ({this.Cells[Selector - 1].Value})\n"; Console.WriteLine(str);
        private void Write(string input,int index)
        {
            if(this.Selector == index)
            {
                if (this.Cells[this.Selector].IsEmpty)
                {
                    Console.ForegroundColor = this.FocusColor;
                    Console.BackgroundColor = this.BackGroundColor;
                    Console.Write($"{this.Player[this.CurrentPlayer]}");
                    return; 
                }
                Console.ForegroundColor = this.AlertColor;
                Console.BackgroundColor = this.BackGroundColor;
                Console.Write(input);
                return;
            }
            else
            {
                Console.BackgroundColor = this.BackGroundColor;
                Console.ForegroundColor = this.TextColor; 
                Console.Write(input);
                return;
            }

        }


        public void Start()
        {
            PrintMap();
            //this.FillWithNumber = true; 
        }
        public Game()
        {
            this.Cells = new Cell[] {new Cell(),new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() };
        }
    }
}
