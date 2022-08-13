public class Battleship2
{
    internal void Header()
    {
        Console.WriteLine("██████╗░░█████╗░████████╗████████╗██╗░░░░░███████╗░██████╗██╗░░██╗██╗██████╗░");
        Console.WriteLine("██╔══██╗██╔══██╗╚══██╔══╝╚══██╔══╝██║░░░░░██╔════╝██╔════╝██║░░██║██║██╔══██╗");
        Console.WriteLine("██████╦╝███████║░░░██║░░░░░░██║░░░██║░░░░░█████╗░░╚█████╗░███████║██║██████╔╝");
        Console.WriteLine("██╔══██╗██╔══██║░░░██║░░░░░░██║░░░██║░░░░░██╔══╝░░░╚═══██╗██╔══██║██║██╔═══╝░");
        Console.WriteLine("██████╦╝██║░░██║░░░██║░░░░░░██║░░░███████╗███████╗██████╔╝██║░░██║██║██║░░░░░");
        Console.WriteLine("╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░░░░╚═╝░░░╚══════╝╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░░░░");
        Console.WriteLine("Game made by Adrian, Alex & Kasia in C#");
    }

    internal void Display()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Enter \"1\": Start New Game");
        Console.WriteLine("Enter \"2\": View High Score");
        Console.WriteLine("Enter \"3\": Exit");
        Console.ResetColor();
    }

    internal void MenuActionSelected(int menuAction)
    {
        switch (menuAction)
        {
            case 1:
                Console.WriteLine("You started new game");
                break;
            case 2:
                Console.WriteLine("You viewed the highscore");
                break;
            case 3:
                Console.WriteLine("You exited");
                break;
            default:
                Console.WriteLine("Please choose the right number");
                int menuAction2 = Convert.ToInt32(Console.ReadLine());
                MenuActionSelected(menuAction2);
                break;
        }
    }
}