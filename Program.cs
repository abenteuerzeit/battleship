// See https://aka.ms/new-console-template for more information
Console.WriteLine("██████╗░░█████╗░████████╗████████╗██╗░░░░░███████╗░██████╗██╗░░██╗██╗██████╗░");
Console.WriteLine("██╔══██╗██╔══██╗╚══██╔══╝╚══██╔══╝██║░░░░░██╔════╝██╔════╝██║░░██║██║██╔══██╗");
Console.WriteLine("██████╦╝███████║░░░██║░░░░░░██║░░░██║░░░░░█████╗░░╚█████╗░███████║██║██████╔╝");
Console.WriteLine("██╔══██╗██╔══██║░░░██║░░░░░░██║░░░██║░░░░░██╔══╝░░░╚═══██╗██╔══██║██║██╔═══╝░");
Console.WriteLine("██████╦╝██║░░██║░░░██║░░░░░░██║░░░███████╗███████╗██████╔╝██║░░██║██║██║░░░░░");
Console.WriteLine("╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░░░░╚═╝░░░╚══════╝╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░░░░");
Console.WriteLine("Game made by Adrian, Alex & Kasia in C#");
Console.WriteLine("Enter \"1\": Start New Game");
Console.WriteLine("Enter \"2\": View High Score");
Console.WriteLine("Enter \"3\": Exit");
int menuAction = Convert.ToInt32(Console.ReadLine());
switch(menuAction)
{
    case 1:
        Console.WriteLine("You started new game");
        break;
    case 2:
        Console.WriteLine("You viewed highscore");
        break;
    case 3:
        Console.WriteLine("You exit");
        break;
    default:
        Console.WriteLine("Please choose right number");
        break;
}