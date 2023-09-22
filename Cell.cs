using System;
namespace TTT
{
    public class Cell
    {
        public Char Value { get; set; } = ' ';
        public Boolean IsEmpty { get; set; } = true;
        public void Reset()
        {
            this.Value = ' ';
            this.IsEmpty = true; 
        }
    }

}
