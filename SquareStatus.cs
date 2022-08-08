namespace Battleship
{
    public class SquareStatus
    {
        // The SquareStatus enum represents possible square statuses (empty, ship, hit, missed).

        public enum Status
        {
            Empty,
            Ship,
            Hit,
            Missed
        }

        // Each SquareStatus has a unicode character that can be used for printing it out. This unicode character is returned by Square.GetCharacter() method.
        public string symbol;
        public string GetCharacter(string symbol)
        {
            this.symbol = symbol;

            if (symbol == "Empty")
            {
                return "E";
            }
            else if (symbol == "Ship")
            {
                return "S";
            }
            else if (symbol == "Hit")
            {
                return "H";
            }
            else
            {
                return "M";
            }
        }

    }


}





