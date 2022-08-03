using System.Collections.Generic;

namespace battleship_oop_csharp
{
    internal class Ship
    {
        List<Square> shipLocations;
    }

    enum ShipType
    {
        Destroyer = 1,
        Submarine = 2,
        Battleship = 3,
        Cruiser = 4,
        Carrier = 5
    }
}
