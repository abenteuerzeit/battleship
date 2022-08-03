using System;

namespace battleship_oop_csharp
{
    internal class Display
    {
        private string[] Menu { get; set; }
        private int[,] Board { get; set; }

        /*
         * Implement the Display class and its methods.
         * The Display class prints the game menu.
         * The Display class prints the board during manual ship placement process.
         * The Display class prints the gameplay.
         * The Display class prints the outcome of the game when it is over.
         * No Console.WriteLine() happens outside of the Display class. 
         */
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }


}
