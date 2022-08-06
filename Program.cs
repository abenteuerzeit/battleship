// See https://aka.ms/new-console-template for more information
Battleship menu = new Battleship();
Input menuInput = new Input();
menu.Header();
menu.Display();
int menuAction = menuInput.MenuAction();
menu.MenuActionSelected(menuAction);
Board player1board = new Board();
string[,] Ocean = new string[11, 11];
player1board.BoardDisplay(Ocean);