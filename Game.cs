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

        private void PrintMap()
        {
            Console.Clear();
            if (this.FillWithNumber)
            {

                 for(int item = 0; item < this.Cells.Length; item++)
                {
                    if (this.Cells[item].Value == ' ')
                    {
                        this.Cells[item].Value = (item + 1).ToString()[0];
                    }
                }
            }

            this.Write("\t",777); 
            this.Write($"{this.Cells[0].Value}",0);
            this.Write("  |  ", 777);
            this.Write($"{this.Cells[1].Value}",1);
            this.Write("  |  ", 777);
            this.Write($"{this.Cells[2].Value}",2);
            this.Write("\n", 777); 
            this.Write("\t___|_____|___\n",777);
            this.Write("\t   |     |\n", 777);
            this.Write("\t",777);
            this.Write($"{this.Cells[3].Value}", 3);
            this.Write("  |  ", 777);
            this.Write($"{this.Cells[4].Value}", 4);
            this.Write("  |  ", 777);
            this.Write($"{this.Cells[5].Value}", 5);
            this.Write("\n", 777);
            this.Write("\t___|_____|___\n", 777);
            this.Write("\t   |     |\n", 777);
            this.Write("\t", 777); 
            this.Write($"{this.Cells[6].Value}", 6);
            this.Write("  |  ", 777);
            this.Write($"{this.Cells[7].Value}", 7);
            this.Write("  |  ", 777);
            this.Write($"{this.Cells[8].Value}", 8);
            this.Write("\n", 777); this.GameLoop();
            //Console.ReadKey(); 
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
