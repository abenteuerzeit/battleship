using System;

namespace battleship_oop_csharp
{
    internal class Square
    {
        public SquareStatus status;
        private (int x, int y) Position { get; set; }

        public char GetCharacter(SquareStatus input)
        {
            char result = Convert.ToChar(input);
            Console.WriteLine($"Get character called. Returned: {result}");
            return result;
        }

        public void GetSquareGraphics()
        {
            Console.WriteLine("method that returns a graphical representation of SquareStatus");
        }


        public enum SquareStatus
        //Each SquareStatus has a unicode character that can be used for printing it out
        {
            Empty,
            Ship,
            Hit,
            Missed
        }
    }
}
