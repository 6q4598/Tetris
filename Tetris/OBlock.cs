namespace Tetris {

    /*
     * Set the tetromino O propierties.
     * The functionalities are implemented in the <<Block>> class.
     */

    public class OBlock : Block {

        public readonly Position[][] tiles = new Position[][] {

            new Position[] { new(0, 0), new(0, 1), new(1, 0), new(1, 1) }

        };

        // Set tetromino identification
        public override int Id => 7;
        
        // Generates the tetromino in the middle of the top row.
        protected override Position StartOffset => new Position(0, 4);
        
        // Returns the array of tetrominos in the up.
        protected override Position[][] Tiles => tiles;

    }

}
