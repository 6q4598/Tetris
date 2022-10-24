namespace Tetris {

    /*
     * Set the tetromino J propierties.
     * The functionalities are implemented in the <<Block>> class.
     */

    public class JBlock : Block {

        // First, save the tetromino for each of the four states of the rotation.
        private readonly Position[][] tiles = new Position[][] {

            new Position[] { new(0, 0), new(1, 0), new(1, 1), new(1, 2) },
            new Position[] { new(0, 1), new(0, 2), new(1, 1), new(2, 1) },
            new Position[] { new(1, 0), new(1, 1), new(1, 2), new(2, 2) },
            new Position[] { new(0, 1), new(1, 1), new(2, 0), new(2, 1) }

        };

        // Set tetromino identification
        public override int Id => 2;

        // Generates the tetromino in the middle of the top row.
        protected override Position StartOffset => new Position(-1, 3);

        // Returns the array of tetrominos in the up.
        protected override Position[][] Tiles => tiles;

    }

}
