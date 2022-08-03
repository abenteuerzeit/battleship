using System;

namespace battleship_oop_csharp
{
    internal class Battleship
    {
        public Display display;
        public Input input;

        public void RunGame()
        {
            // TODO: Display Menu


            bool gameOver = false;

            while (!gameOver)
            {
                string quit = Console.ReadLine();
                if (quit.ToLower() == "quit" || quit.ToLower() == "q")
                {
                    gameOver = true;
                }
            }
        }

        private enum MenuOptions
        {
            StartNewGame,
            DisplayHighScores,
            Exit
        }
    }
}
