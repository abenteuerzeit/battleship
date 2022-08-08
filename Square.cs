namespace Battleship
{

    internal class Square

    {
        private int x;
        private int y;
        private SquareStatus squareStatus;
        
        // The Square class has a Position property.The property is a tuple consisting of x and y coordinates.

        public (int, int) Position;
        //The Square class has a SquareStatus field.
        //The Square class has method that returns a graphical representation of SquareStatus.

        

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

       
        public SquareStatus getSquareStatus()
        {
            return squareStatus;
        }
    }
}
