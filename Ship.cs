namespace Battleship
{
    public class Ship
    {
        // The Ship class has a List<Square> field. It contains the squares where the ship is located.

        // public List<Square> // TODO


        // The ShipType enum represents ship types. The types are Carrier, Cruiser, Battleship, Submarine, and Destroyer.
        //Each ShipType has a unique length.

        public enum Type
        {
            Carrier = 5,
            Battleship = 4,
            Cruiser = 3,
            Submarine = 2,
            Destroyer = 1
        }

        /*        private string name;
                private int size;

                public void Type(string name, int size)
                {
                    this.name = name;
                    this.size = size;
                }*/

    }
}
