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
	public void BoardDisplay(string[,] Ocean)
    {
		for (int row = 0; row < 11; row++)
		{
			for (int col = 0; col < 11; col++)
			{
				if (col==0)
                {
					Console.ForegroundColor = ConsoleColor.Green;
				}
				if (Ocean[row,col]=="~")
                {
					Console.ForegroundColor = ConsoleColor.Blue;
				}
				Console.Write("[" + Ocean[row, col] + "]");
			}
			Console.WriteLine();
		}
	}
}
