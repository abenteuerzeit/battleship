using System;

public class Board
{
	public Board()
	{
		string[] RowHeader = { "#", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
		string[] FirstRow = { "#", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
		string[,] Ocean = new string[11, 11];
		for (int col = 0; col < 11; col++)
		{
			Ocean[0, col] = FirstRow[col];
		}
		for (int row = 0; row < 11; row++)
		{
			Ocean[row, 0] = RowHeader[row];
		}
		for (int col = 1; col < 11; col++)
		{
			for (int row = 1; row < 11; row++)
			{
				Ocean[col, row] = "~";
			}
		}
	}

	public void CreateBoard(string[,] Ocean)
    {
		string[] RowHeader = { "#", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
		string[] FirstRow = { "#", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
		for (int col = 0; col < 11; col++)
		{
			Ocean[0, col] = FirstRow[col];
		}
		for (int row = 0; row < 11; row++)
		{
			Ocean[row, 0] = RowHeader[row];
		}
		for (int col = 1; col < 11; col++)
		{
			for (int row = 1; row < 11; row++)
			{
				Ocean[col, row] = "~";
			}
		}
	}

	public void PlaceShips(string[,] Ocean)
    {
		string[] ShipsNames = { "Carrier", "Battleship", "Cruiser", "Submarine", "Destroyer" };
		int[] ShipsLength = { 5, 4, 3, 3, 2 };
		foreach (string ShipName in ShipsNames)
        {
			Console.WriteLine("Please place your: " + ShipName);
			int ShipLength = 0;
			switch (ShipName)
            {
				case "Carrier":
					ShipLength = 5;
					break;
				case "Battleship":
					ShipLength = 4;
					break;
				case "Cruiser":
					ShipLength = 3;
					break;
				case "Submarine":
					ShipLength = 3;
					break;
				case "Destroyer":
					ShipLength = 2;
					break;
            }
			Console.WriteLine("Provide x-axis of Your: " + ShipName);
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Provide y-axis of Your: " + ShipName);
			int y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Provide direction of Your ship placement (N - North, S - South, E - East, W - West)");
			string direction = Console.ReadLine();
			for (int i = ShipLength; i > 0; i--)
            {
				Ocean[y, x] = "O";
				switch (direction)
                {
					case "N":
						y--;
						break;
					case "S":
						y++;
						break;
					case "W":
						x--;
						break;
					case "E":
						x++;
						break;
                }
            }
			Console.Clear();
			BoardDisplay(Ocean);
		}
    }


	public void BoardDisplay(string[,] Ocean)
    {
		for (int row = 0; row < 11; row++)
		{
			for (int col = 0; col < 11; col++)
			{
				string Field = Ocean[row, col];
				switch (Field)
                {
					case "~":
						Console.ForegroundColor = ConsoleColor.Blue;
						break;
					case "O":
						Console.ForegroundColor = ConsoleColor.Green;
						break;
					default:
						Console.ForegroundColor = ConsoleColor.Yellow;
						break;
                }
				Console.Write("[" + Ocean[row, col] + "]");
			}
			Console.WriteLine();
		}
		Console.ForegroundColor = ConsoleColor.White;
	}
}
