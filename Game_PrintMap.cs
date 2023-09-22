using System;
namespace TTT
{
    public partial class Game
    {
        private void PrintMap()
        {
            Console.Clear();
            if (this.FillWithNumber)
            {

                for (int item = 0; item < this.Cells.Length; item++)
                {
                    if (this.Cells[item].Value == ' ')
                    {
                        this.Cells[item].Value = (item + 1).ToString()[0];
                    }
                }
            }

            /*
                i know that this looks horrific melqui from the future or anybody reading this
                yes , i was under some sort of D$!@ while making it , Lol BUT 
                being real i was having problems to implement the body of the Tic tac toe on a way 
                that i could also modify the color of it when is fucused so i had to 
                create a wraper around the Console.Write(object) 
                then i pass is to my costum method and if is meeting the 
                same index value than the focus it will give the color focus to it 
                the number 777 was shosed due to my obsetion with that number
                on linux , and lastly the chars such as \t \n and | or ___
                were move to be printed separetly to make sure that they don't also change the color               
            */
            Console.WriteLine("\n"); 
            this.Write("\t", 777);
            this.Write($"{this.Cells[0].Value}", 0);
            this.Write("  |  ", 777);
            this.Write($"{this.Cells[1].Value}", 1);
            this.Write("  |  ", 777);
            this.Write($"{this.Cells[2].Value}", 2);
            this.Write("\n", 777);
            this.Write("\t___|_____|___\n", 777);
            this.Write("\t   |     |\n", 777);
            this.Write("\t", 777);
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
    }
}
