// See https://aka.ms/new-console-template for more information

Battleship2 menu = new Battleship2();
Input menuInput = new Input();
menu.Header();
menu.Display();
int menuAction = menuInput.MenuAction();
menu.MenuActionSelected(menuAction);
string[,] Ocean = new string[11, 11];
string[,] Ocean2 = new string[11, 11];
Board player1board = new Board();
player1board.CreateBoard(Ocean);
player1board.PlaceShips(Ocean);

Board player2board = new Board();
player2board.CreateBoard(Ocean2);
player2board.PlaceShips(Ocean2);

void StartGame()
{
    int player1Lives = 17;
    int player2Lives = 17;
    bool gamePlay = true;
    while (gamePlay == true)
    {
        Console.Clear();
        Console.WriteLine("Turn for player 1");
        Console.WriteLine("Player 2 board display");
        Console.WriteLine("Player 2 has :" + player2Lives + " Lives");
        player2board.BoardDisplay(Ocean2);

        Console.WriteLine("Provide x axis You want to shoot");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Provide y axis You want to shoot");
        int y = Convert.ToInt32(Console.ReadLine());

        switch (Ocean2[y,x])
        {
            case "O":
                player2Lives--;
                Ocean2[y, x] = "*";
                break;
            case "~":
                Ocean2[y, x] = "M";
                break;
        }
        if (player1Lives == 0)
        {
            Console.Clear();
            player2board.BoardDisplay(Ocean2);
            Console.WriteLine("Player 2 Wins");
            gamePlay = false;
        }
        if (player2Lives == 0)
        {
            Console.WriteLine("Player 1 Wins");
            gamePlay = false;
        }
    }
}

StartGame();