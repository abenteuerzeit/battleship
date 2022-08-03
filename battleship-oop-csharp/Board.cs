using System;

namespace battleship_oop_csharp
{
    internal class Board
    {
        Square[,] ocean { get; set; }


        private bool IsPlacementOk()
        {
            Console.WriteLine("Is placement ok method called");
            return false;
        }
    }

}
